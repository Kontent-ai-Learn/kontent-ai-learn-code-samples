// DocSection: first_react_app_viewarticleitemresolver
//...
import { resolveItemInRichText } from './itemResolver';
//...

fetchArticle(slug) {
  client.items()
    .equalsFilter('elements.url_pattern', slug)
    .depthParameter(1)
    .queryConfig({
      richTextResolver: resolveItemInRichText,
    })
    .toObservable()
    .subscribe((response) => {
      console.log(response);
      this.setState({
        loaded: true,
        article: response.items[0]
      });
    });
}
// EndDocSection