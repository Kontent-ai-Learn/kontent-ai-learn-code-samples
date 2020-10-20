// DocSection: getting_localized_content_url_slug
// Tip: Find more about JavaRx SDK at https://docs.kontent.ai/androidandroid

// Prepares the DeliveryOptions configuration object
DeliveryOptions options = DeliveryOptions.builder()
    .projectId("<YOUR_PROJECT_ID>")
    .build();

// Initializes a DeliveryClient for Java projects
DeliveryClient client = new DeliveryClient(options);

// Registers the model class for articles
client.registerType(Article.class);

// Gets the Spanish variant of an "About us" content item that has "acerda-de-nosotros" in its "URL pattern" element using a simple request
CompletionStage<List<Article>> articles = client.getItems(
    Article.class,
    DeliveryParameterBuilder.params()
        .language("es-ES")
        .filterEquals("elements.url_pattern", "acerca-de-nosotros")
        .build()
);

// Gets the Spanish variant of an "About us" content item that has "acerda-de-nosotros" in its "URL pattern" element using RxJava
Observable.fromCompletionStage(articles)
    .subscribe(new Observer<List<Article>>() {
        @Override
        public void onSubscribe(@NonNull Disposable d) {
        }

        @Override
        public void onNext(@NonNull List<Article> articles) {
            // Gets the content item
            Article article = articles.get(0);
        }

        @Override
        public void onError(@NonNull Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection