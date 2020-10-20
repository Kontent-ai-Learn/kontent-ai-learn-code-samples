// DocSection: getting_content_filter_items
// Tip: Find more about JavaRx SDK at https://docs.kontent.ai/androidandroid
// Prepares the DeliveryOptions configuration object
DeliveryOptions options = DeliveryOptions.builder()
    .projectId("<YOUR_PROJECT_ID>")
    .build();

// Initializes a DeliveryClient for Java projects
DeliveryClient client = new DeliveryClient(options);

// Registers the model class for articles
client.registerType(Article.class);

// Gets all articles using a simple request
CompletionStage<List<Article>> articles = client.getItems(Article.class);

// Gets all articles using RxJava
Observable.fromCompletionStage(client.getItems(Article.class))
    .subscribe(new Observer<List<Article>>() {
        @Override
        public void onSubscribe(@NonNull Disposable d) {
        }

        @Override
        public void onNext(@NonNull List<Article> items) {
            // Gets the articles
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