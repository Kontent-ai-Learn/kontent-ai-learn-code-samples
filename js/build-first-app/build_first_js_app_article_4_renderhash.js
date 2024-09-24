// Reload page on hash change
const renderHash = () => {
  window.history.go();
};
window.addEventListener('hashchange', renderHash, false);
