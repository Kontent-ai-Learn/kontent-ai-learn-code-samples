// DocSection: build_first_js_app_core_4_reporterror
// Error messages
const reportErrors = err => {
  console.error(err);
  app.innerHTML = `<p>An error occured 😞:</p><p><i>${err}</i></p>`;
};
// EndDocSection