// DocSection: build_first_js_app_articlelist_2_deliveryclient
// Call for a list of all articles
deliveryClient
  .items()
  .type('article')
  .toPromise()
  .then(response => {
    console.log(response)
  });
// EndDocSection