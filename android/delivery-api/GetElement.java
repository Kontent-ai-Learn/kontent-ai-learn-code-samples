// DocSection: delivery_api_get_element
// Tip: Find more about JavaRx SDK at https://docs.kontent.ai/androidandroid

// Prepares the DeliveryService configuration object
DeliveryOptions options = DeliveryOptions.builder()
    .projectId("<YOUR_PROJECT_ID>")
    .build();

// Initializes a DeliveryClient for Java projects
DeliveryClient client = new DeliveryClient(options);

// Gets the "title" content element from the "article" type using a simple request
CompletionStage<Element> element = client.getContentTypeElement("article", "title");

// Gets the "title" content element from the "article" type using RxJava
Observable.fromCompletionStage(element)
    .subscribe(new Observer<Element>() {
        @Override
        public void onSubscribe(Disposable d) {
        }

        @Override
        public void onNext(Element element) {
            // Gets the element
            Element titleElement = element;
        }

        @Override
        public void onError(Throwable e) {
        }

        @Override
        public void onComplete() {
        }
    });
// EndDocSection