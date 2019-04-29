// DocSection: first_react_app_viewarticlelinkresolver
//...
import { resolveContentLink } from './linkResolver';
//...

fetchArticle(slug) {
  client.items()
    .equalsFilter('elements.url_pattern', slug)
    .depthParameter(1)
    .queryConfig({
      linkResolver: resolveContentLink,
    })
    .getObservable()
    .subscribe((response) => {
      console.log(response);
      this.setState({
        loaded: true,
        article: response.items[0]
      });
    });
}
// EndDocSection