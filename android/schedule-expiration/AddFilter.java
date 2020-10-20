// DocSection: schedule_expiration_add_filter
// Tip: Find more about JavaRx SDK at https://docs.kontent.ai/androidandroid

// Prepares the DeliveryOptions configuration object
DeliveryOptions options = DeliveryOptions.builder()
.projectId("8d20758c-d74c-4f59-ae04-ee928c0816b7")
.build();

// Initializes a DeliveryClient for Java projects
DeliveryClient client = new DeliveryClient(options);

// Registers the model class for landing pages
client.registerType(LandingPage.class);

CompletionStage<List<LandingPage>> publishedItems = client.getItems(
                LandingPage.class,
                DeliveryParameterBuilder.params()
                        .filterEquals("system.type", "landing_page")
                        .build()
        ).thenApply(landingPageItems -> landingPageItems.stream()
                .filter(item ->
                        (item.getExpireAt().compareTo(ZonedDateTime.now()) > 0 || item.getExpireAt() == null))
                .collect(Collectors.toList()));


// Gets all landing pages using RxJava
Observable.fromCompletionStage(publishedItems)
    .subscribe(new Observer<List<LandingPage>>() {
        @Override
        public void onSubscribe(Disposable d) {
        }

        @Override
        public void onNext(List<LandingPage> landingPages) {
            // Already landing pages, that should be public
            List<LandingPage> publishedItems = landingPages;
        }

        @Override
        public void onError(Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection