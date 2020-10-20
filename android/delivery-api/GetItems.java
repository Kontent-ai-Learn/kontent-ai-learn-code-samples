// DocSection: delivery_api_get_items
// Tip: Find more about JavaRx SDK at https://docs.kontent.ai/androidandroid
// Prepares the DeliveryOptions configuration object
DeliveryOptions options = DeliveryOptions.builder()
    .projectId("<YOUR_PROJECT_ID>")
    .build();

// Initializes a DeliveryClient for Java projects
DeliveryClient client = new DeliveryClient(options);

// Registers the model class for articles
client.registerType(Article.class);


// Gets specific elements of 3 articles ordered by the "Post date" element using a simple request
CompletionStage<List<Article>> articles = client.getItems(
    Article.class,
    DeliveryParameterBuilder.params().page(null, 3).orderByDesc("post_date").build()
);

// Gets specific elements of 3 articles ordered by the "Post date" element using RxJava
Observable.fromCompletionStage(
        client.getItems(
                Article.class,
                DeliveryParameterBuilder.params().page(null, 3).orderByDesc("post_date").build()
        )
).subscribe(new Observer<List<Article>>() {
    @Override
    public void onSubscribe(@NonNull Disposable d) {
    }

    @Override
    public void onNext(@NonNull List<Article> items) {
        // Gets the mapped articles
        List<Article> articles = items;
    }

    @Override
    public void onError(@NonNull Throwable e) {
    }

    @Override
    public void onComplete() {
    }
});
// EndDocSection