// DocSection: build_first_js_app_article_1_createnodes
// Define which article is being retrieved
const articleSlug = location.hash.slice(1);

// Create article container
const articleContainer = addToElementbyId('div', 'article', app);

// Call for article info
deliveryClient
  .items()
  .type('article')
  .equalsFilter('elements.url_pattern', articleSlug)
  .toPromise()
  .then(response => {
    // Check if article found before adding
    const article =
      response.data.items && response.data.items.length ? response.data.items[0] : undefined;

    // Update title
    document.title = `Article | ${article.system.name}`;

    // Create nodes
    const headerImage = createElement(
      'img',
      'article-header',
      'src',
      article.elements.teaser_image.value[0].url
    );
    const title = createElement(
      'h2',
      'article-title',
      'innerText',
      article.elements.title.value
    );
    const richTextElement = article.elements.body_copy;
    const rteResolver = Kk.createRichTextHtmlResolver().resolveRichText({
      element: richTextElement,
      // Here you'll define your resolvers
    });
    const body = createElement(
      'div',
      'article-description',
      'innerHTML',
      rteResolver.html
    );

    // Add nodes to DOM
    articleContainer.append(headerImage, title, body);
    return;
  });
// EndDocSection