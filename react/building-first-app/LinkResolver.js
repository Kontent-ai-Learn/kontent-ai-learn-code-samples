// DocSection: first_react_app_linkresolver
export const resolveContentLink = (link) => {
    if (link.type === 'article') {
      return `/post/${link.urlSlug}`;
    }
    return undefined;
  };
// EndDocSection