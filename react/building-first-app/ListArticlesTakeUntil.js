// DocSection: first_react_app_list_articles_takeuntil
import { client } from './config';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
// ...

let unsubscribeSubject = new Subject();

class ArticleListing extends Component {
  // ...

  fetchArticles() {
    client.items()
      .type('article')
      .elementsParameter(['url_pattern', 'title'])
      .toObservable()
      // unsubscribe when unsubscribeSubject fires
      .pipe(takeUntil(unsubscribeSubject))
      .subscribe(response => {
        console.log(response.items);
        this.setState({
          loaded: true,
          articles: response.items
        });
      });
  }

  unsubscribe() {
    unsubscribeSubject.next();
    unsubscribeSubject.complete();
  }

  componentWillUnmount() {
    this.unsubscribe();
  }
}
// EndDocSection