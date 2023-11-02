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
