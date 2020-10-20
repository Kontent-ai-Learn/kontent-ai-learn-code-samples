// DocSection: language_fallbacks_ignore
// Tip: Find more about JavaRx SDK at https://docs.kontent.ai/androidandroid

// Prepares the DeliveryOptions configuration object
DeliveryOptions options = DeliveryOptions.builder()
    .projectId("<YOUR_PROJECT_ID>")
    .build();

// Initializes a DeliveryClient for Java projects
DeliveryClient client = new DeliveryClient(options);

// Registers the model class for articles
client.registerType(Article.class);

// Gets the Spanish variant of all content items (while ignoring language fallbacks) using a simple request
CompletionStage<ContentItemsListingResponse> articles = client.getItems(DeliveryParameterBuilder.params()
    .language("es-ES")
    .filterEquals("system.language", "es-ES")
    .build()
);

// Gets the Spanish variant of all content items (while ignoring language fallbacks) using RxJava
Observable.fromCompletionStage(articles).subscribe(new Observer<ContentItemsListingResponse>() {
    @Override
    public void onSubscribe(@NonNull Disposable d) {
    }

    @Override
    public void onNext(@NonNull ContentItemsListingResponse items) {
        // Gets the content items
        List<ContentItem> article = items.getItems();
    }

    @Override
    public void onError(@NonNull Throwable e) {
    }

    @Override
    public void onComplete() {
    }
});
// EndDocSection
