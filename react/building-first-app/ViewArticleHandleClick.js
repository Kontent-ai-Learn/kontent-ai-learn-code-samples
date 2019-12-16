// DocSection: first_react_app_viewarticlehandleclick
handleClick(event, richTextElement) {
    if (event.target.tagName === 'A' && event.target.hasAttribute('data-item-id')) {
      event.preventDefault();
  
      const id = event.target.getAttribute('data-item-id');
      const link = richTextElement.links.find(link => link.linkId === id);
      const newPath = resolveContentLink(link).url;
      if (newPath) {
        this.props.history.push(newPath);
      }
    }
  }
// EndDocSection