// DocSection: build_first_js_app_article_7_error
deliveryClient
  .items()
  .type('article')
  .equalsFilter('elements.url_pattern', articleSlug)
  .toPromise()
  .then(response => {
    // Check if article found before adding
    const article =
      response.data.items && response.data.items.length ? response.data.items[0] : undefined;

    // 404 message if not found
    if (!article) {
      app.innerHTML = '<p>That article could not be found.</p>';
      return;
    }
  })
  .catch(err => {
    reportErrors(err);
  });
// EndDocSection