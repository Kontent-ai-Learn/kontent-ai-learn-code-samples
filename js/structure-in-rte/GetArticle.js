// DocSection: structure_in_rte_retrieve_article
var deliveryClient = new DeliveryClient({
    projectId: 'e6d2946e-0e24-003f-a397-9d2d458c6d6e', 
    typeResolvers: typeResolvers
});

deliveryClient.item('the_origin_of_coffee')    
    .getObservable()
    .subscribe(response => {
        console.log(response);
        document.getElementById("mainContent").innerHTML = response.item.body.getHtml();
});
// EndDocSection