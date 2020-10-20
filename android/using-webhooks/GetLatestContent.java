// DocSection: using_webhooks_get_latest_content
// Tip: Find more about JavaRx SDK at https://docs.kontent.ai/androidandroid

 // Prepares the DeliveryOptions configuration object
 DeliveryOptions options = DeliveryOptions.builder()
 .projectId("<YOUR_PROJECT_ID>")
 .waitForLoadingNewContent(true)
 .build();

// Initializes a DeliveryClient for Java projects
DeliveryClient client = new DeliveryClient(options);

// Registers the model class for articles
client.registerType(Article.class);

// Gets an article using a simple request
CompletionStage<Article> article = client.getItem("my_article", Article.class);

// Gets specific elements of an article using RxJava
Observable.fromCompletionStage(article)
    .subscribe(new Observer<Article>() {
        @Override
        public void onSubscribe(Disposable d) {
        }

        @Override
        public void onNext(Article item) {
            // Gets the content item
            Article article = item;
        }

        @Override
        public void onError(Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection