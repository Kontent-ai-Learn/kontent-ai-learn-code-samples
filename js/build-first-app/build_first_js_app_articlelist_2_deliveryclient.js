// Call for a list of all articles
deliveryClient
  .items()
  .type('article')
  .toPromise()
  .then(response => {
    console.log(response)
  });
