// DocSection: first_react_app_view_article
import React, { Component } from 'react';
import { Link } from 'react-router-dom'
import { DeliveryClient } from '@kentico/kontent-delivery';

const client = new DeliveryClient({ projectId: '975bf280-fd91-488c-994c-2f04416e5ee3' });

class ArticleView extends Component {
  constructor(props) {
    super(props);

    this.state = {
      loaded: false,
      article: null
    };
  }
   
  fetchArticle(slug) {
    client.items()
      .equalsFilter('elements.url_pattern', slug)
      .depthParameter(1)
      .toObservable()
      .subscribe((response) => {
        console.log(response);
        this.setState({
          loaded: true,
          article: response.items[0]
        });
      });
  }
  
  componentDidMount() {
    let slug = this.props.match.params.slug;
    this.fetchArticle(slug);
  }

 render = (props) => {
    if (this.state.loaded) {
      const article = this.state.article;
      const title = article.title.value;
      const bodyCopy = article.body_copy;

      return (
        <div>
          <Link to="/">Home</Link>
          <h1>{title}</h1>
          <div className="article_body"
            dangerouslySetInnerHTML={{ __html: bodyCopy.resolveHtml() }} />
        </div>
      );
    } else {
      return (
        <div>
          Loading...
        </div>
      );
    }
  }
}

export default ArticleView;
// EndDocSection