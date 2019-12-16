// DocSection: first_react_app_linkresolver
export const resolveContentLink = (link) => {
    if (link.type === 'article') {
      return {url: `/post/${link.urlSlug}`};
    }
    return undefined;
  };
// EndDocSection