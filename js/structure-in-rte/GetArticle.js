// DocSection: structure_in_rte_retrieve_article
var deliveryClient = new DeliveryClient({
    projectId: '<YOUR_PROJECT_ID>',
    typeResolvers: typeResolvers
});

deliveryClient.item('my_article')    
    .toObservable()
    .subscribe(response => {
        console.log(response);
        document.getElementById('mainContent').innerHTML = response.item.body.resolveHtml();
});
// EndDocSection
