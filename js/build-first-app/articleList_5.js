// DocSection: build_first_js_app_articlelist_5_error
deliveryClient
  .items()
  .type('article')
  .toPromise()
  .then(response => {
    // Your current code
  })
  .catch(err => {
    reportErrors(err);
  });
// EndDocSection