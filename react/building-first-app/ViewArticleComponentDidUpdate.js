// DocSection: first_react_app_componentdidupdate
componentDidUpdate(oldprops) {
    let oldSlug = oldprops.match.params.slug;
    let newSlug = this.props.match.params.slug;
    if (oldSlug !== newSlug) {
      this.fetchArticle(newSlug);
    }
  }
// EndDocSection