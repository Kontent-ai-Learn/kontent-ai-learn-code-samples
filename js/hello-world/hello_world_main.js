// Initializes the Delivery JS SDK
var KontentDelivery = window['kontentDelivery'];

// Creates a delivery client for retrieving data from Kontent.ai
const deliveryClient = new KontentDelivery.createDeliveryClient({
  // Tip: Use your project ID to display your own content.
  environmentId: '8d20758c-d74c-4f59-ae04-ee928c0816b7'
});

// Retrieves the content item
deliveryClient
  .item('hello_headless_world')
  .elementsParameter(['headline', 'body_text', 'picture'])
  .toPromise()
  .then((response) => processData(response));

// Processes the retrieved data and displays it on the page.
function processData(response) {
  const bodyText = response.data.item.elements.body_text.value;
  const headline = response.data.item.elements.headline.value;
  const picture = response.data.item.elements.picture.value[0].url;

  document.getElementById("bodytext").innerHTML = bodyText;
  document.getElementById("headline").append(headline);
  document.getElementById("banner").src = picture;
}
