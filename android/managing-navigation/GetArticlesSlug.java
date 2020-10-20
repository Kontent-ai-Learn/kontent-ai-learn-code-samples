// DocSection: managing_navigation_articles_slugs
// Tip: Find more about JavaRx SDK at https://docs.kontent.ai/androidandroid

// Prepares the DeliveryOptions configuration object
DeliveryOptions options = DeliveryOptions.builder()
    .projectId("<YOUR_PROJECT_ID>")
    .build();

// Initializes a DeliveryClient for Java projects
DeliveryClient client = new DeliveryClient(options);

// Registers the model class for articles
client.registerType(Article.class);

// Gets specific elements of all articles using a simple request
CompletionStage<List<Article>> articles = client.getItems(
    Article.class, 
    DeliveryParameterBuilder.params().projection("title", "url_pattern").build()
);

// Gets specific elements of all articles using JavaRx
Observable.fromCompletionStage(client.getItems(
    Article.class,
    DeliveryParameterBuilder.params().projection("title", "url_pattern").build()
)).subscribe(new Observer<List<Article>>() {
    @Override
    public void onSubscribe(@NonNull Disposable d) {
    }

    @Override
    public void onNext(@NonNull List<Article> items) {
        // Gets the content items
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