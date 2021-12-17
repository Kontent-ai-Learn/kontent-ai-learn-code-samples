// DocSection: build_first_js_app_articlelist_3_createnodes
deliveryClient
  .items()
  .type('article')
  .toPromise()
  .then(response => {
    response.data.items.forEach(item => {
      // Create nodes
      const card = createElement('div', 'card');
      card.classList.add('card-no-link-style');
      const link = createElement(
        'a',
        'link',
        'href',
        './article.html#' + item.elements.url_pattern.value
      );

      // Add nodes to DOM
      articleList.appendChild(card);
      card.appendChild(link);
    });
  });
// EndDocSection