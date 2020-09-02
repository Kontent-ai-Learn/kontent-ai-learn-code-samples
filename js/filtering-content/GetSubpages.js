// DocSection: filtering_get_subpages
// Gets pages linking travel insurance as their subpage.
deliveryClient.items()
    .containsFilter('elements.subpages', ['travel_insurance'])
    .toObservable()
    .subscribe(response => console.log(response));

// Gets pages linking at least travel insurance, car insurance, or both as their subpage.
deliveryClient.items()
    .anyFilter('elements.subpages', ['travel_insurance', 'car_insurance'])
    .toObservable()
    .subscribe(response => console.log(response));
// EndDocSection