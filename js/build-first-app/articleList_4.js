// DocSection: build_first_js_app_articlelist_4_fulllist
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

      const teaser = createElement(
        'img',
        'article-teaser',
        'src',
        item.elements.teaser_image.value && item.elements.teaser_image.value.length
          ? item.elements.teaser_image.value[0].url + '?w=500&h=500'
          : undefined
      );
      const title = createElement(
        'h2',
        'article-title',
        'innerText',
        item.elements.title.value
      );
      const description = createElement(
        'div',
        'article-description',
        'innerHTML',
        item.elements.summary.value
      );

      // Add nodes to DOM
      articleList.appendChild(card);
      card.appendChild(link);
      link.append(teaser, title, description);
    });
  });
// EndDocSection