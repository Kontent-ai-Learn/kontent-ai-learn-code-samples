// DocSection: filtering_get_items_by_datetime
// Note: Date&Time element value is stored with minute precision, system.last_modified value is stored with ms precision.
// Gets items modified after April 9 2020, 9 am UTC+0
deliveryClient.items()
  .greaterThanFilter('system.last_modified', '2020-05-09T09:00:00.000000Z')
  .toObservable()
  .subscribe(response => console.log(response));

// Gets items released at or after April 9 2020, 7 am UTC+0
deliveryClient.items()
  .greaterThanOrEqualFilter('elements.release_date', '2020-05-09T07:00:00Z')
  .toObservable()
  .subscribe(response => console.log(response));

// Gets items modified before April 5 2020 UTC+0. Last match would be at 2020-05-04T23:59:59.
deliveryClient.items()
  .lessThanFilter('system.last_modified', '2020-05-05')
  .toObservable()
  .subscribe(response => console.log(response));

// Gets items released at or before April 5 2020 10:30 am UTC+0
deliveryClient.items()
  .lessThanOrEqualFilter('elements.release_date', '2020-05-05T10:30:00Z')
  .toObservable()
  .subscribe(response => console.log(response));
// EndDocSection 