// DocSection: first_react_app_list_articles
import React, { Component } from 'react';
import { Link } from 'react-router-dom'
import { DeliveryClient } from '@kentico/kontent-delivery';

const client = new DeliveryClient({ projectId: 'a0a9d198-e604-007a-50c9-fecbb46046d1' });

class ArticleListing extends Component {
  constructor(props) {
    super(props);

    this.state = {
      loaded: false
    };
  }

  fetchArticles() {
    client.items()
      .type('article')
      .elementsParameter(['url_pattern', 'title'])
      .toObservable()
      .subscribe(response => {
        console.log(response.items);
        this.setState({
          loaded: true,
          articles: response.items
        });
      });
  }

  componentDidMount() {
    this.fetchArticles();
  }

  render() {
    if (this.state.loaded) {
      return (
        <ul>
          {this.state.articles.map((article) => {
            return (
              <li key={article.url_pattern.value}>
                <Link to={`/post/${article.url_pattern.value}`}>
                  {article.title.value}
                </Link>
              </li>
            )
          })}

        </ul>
      );
    } else {
      return (
        <div>
          Loading...
          </div>
      )
    }
  }
}

export default ArticleListing;
// EndDocSection
