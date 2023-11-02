const rteResolver = Kk.createRichTextHtmlResolver().resolveRichText({
  element: richTextElement,
  linkedItems: Kk.linkedItemsHelper.convertLinkedItemsToArray(response.data.linkedItems),
  urlResolver: (linkId, linkText, link) => {
    // Set link based on type
    const urlLocation =
      link.type === 'article'
        ? `article.html#${link.urlSlug}`
        : link.type === 'coffee'
          ? `coffee.html#${link.urlSlug}`
          : 'unsupported-link';
    return { linkUrl: urlLocation };
  },
});
