// DocSection: preview_content_get_article
// Tip: Find more about JavaRx SDK at https://docs.kontent.ai/androidandroid

// Prepares the DeliveryOptions configuration object
DeliveryOptions options = DeliveryOptions.builder()
    .projectId("<YOUR_PROJECT_ID>")
    .previewApiKey("<YOUR_PREVIEW_API_KEY>")
    .usePreviewApi(true)
    .build();

// Initializes a DeliveryClient for Java projects
DeliveryClient client = new DeliveryClient(options);

// Registers the model class for articles
client.registerType(Article.class);

// Gets the latest version of a content item using a simple request
CompletionStage<Article> article = client.getItem("my_article", Article.class);

// Gets the latest version of a content item using RxJava
Observable.fromCompletionStage(article)
    .subscribe(new Observer<Article>() {
        @Override
        public void onSubscribe(@NonNull Disposable d) {
        }

        @Override
        public void onNext(@NonNull Article item) {
            // Gets the article
            Article article = item;
        }

        @Override
        public void onError(@NonNull Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection