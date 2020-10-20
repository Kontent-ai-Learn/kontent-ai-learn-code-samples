// DocSection: managing_navigation_articles_depth
// Tip: Find more about JavaRx SDK at https://docs.kontent.ai/androidandroid

// Prepares the DeliveryOptions configuration object
DeliveryOptions options = DeliveryOptions.builder()
    .projectId("<YOUR_PROJECT_ID>")
    .build();

// Initializes a DeliveryClient for Java projects
DeliveryClient client = new DeliveryClient(options);

// Registers the model class for navigation items
client.registerType(NavigationItem.class);

// Gets navigation items and their linked items using a simple request
CompletionStage<NavigationItem> root = client.getItem(
    "root_navigation_item",
     NavigationItem.class,
     DeliveryParameterBuilder.params().linkedItemsDepth(5).build()
);

// Gets navigation items and their linked items using RxJava
Observable.fromCompletionStage(root)
    .subscribe(new Observer<NavigationItem>() {
        @Override
        public void onSubscribe(@NonNull Disposable d) {
        }

        @Override
        public void onNext(@NonNull NavigationItem item) {
            // Gets the item
            NavigationItem root = item;
        }

        @Override
        public void onError(@NonNull Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection