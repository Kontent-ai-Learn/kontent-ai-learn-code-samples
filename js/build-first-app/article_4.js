// DocSection: build_first_js_app_article_4_renderhash
// Reload page on hash change
const renderHash = () => {
  window.history.go();
};
window.addEventListener('hashchange', renderHash, false);
// EndDocSection