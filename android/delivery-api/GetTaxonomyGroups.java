// DocSection: delivery_api_get_taxonomy_groups
// Tip: Find more about JavaRx SDK at https://docs.kontent.ai/androidandroid

// Prepares the DeliveryService configuration object
DeliveryOptions options = DeliveryOptions.builder()
        .projectId("<YOUR_PROJECT_ID>")
        .build();

// Initializes a DeliveryClient for Java projects
DeliveryClient client = new DeliveryClient(options);

// Gets 3 taxonomy groups using a simple request
CompletionStage<List<TaxonomyGroup>> taxonomies = client.getTaxonomyGroups(
        DeliveryParameterBuilder.params().page(null, 3).build()
).thenApply(taxonomyGroupListingResponse -> taxonomyGroupListingResponse.getTaxonomies());


// Gets 3 taxonomy groups using RxJava
Observable.fromCompletionStage(
        client.getTaxonomyGroups(DeliveryParameterBuilder.params().page(null, 3).build())
).subscribe(new Observer<TaxonomyGroupListingResponse>() {
    @Override
    public void onSubscribe(@NonNull Disposable d) {
    }

    @Override
    public void onNext(@NonNull TaxonomyGroupListingResponse response) {
        // Gets the taxonomy groups
        List<TaxonomyGroup> taxonomyGroups = response.getTaxonomies();
    }

    @Override
    public void onError(@NonNull Throwable e) {
    }

    @Override
    public void onComplete() {
    }
});
// EndDocSection