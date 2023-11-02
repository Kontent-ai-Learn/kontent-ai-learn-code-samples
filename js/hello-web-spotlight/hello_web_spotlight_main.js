// Initializes the Delivery JS SDK
const KontentDelivery = window['kontentDelivery'];

// Tip: Change the project ID of the API call to yours to display your own content. Make sure the codenames still match.
const deliveryClient = new KontentDelivery.createDeliveryClient({
  environmentId: '8d20758c-d74c-4f59-ae04-ee928c0816b7',
});

// Retrieves the landing page from your project
deliveryClient
  .item('hello_ws_landing_page')
  .elementsParameter(['heading', 'body', 'image'])
  .toPromise()
  .then(response => processData(response));

// Processes the retrieved data and displays it on the page.
function processData(response) {
  const bodyText = response.data.item.elements.body.value;
  const headline = response.data.item.elements.heading.value;
  const picture = response.data.item.elements.image.value[0].url;

  document.getElementById("bodytext").innerHTML = bodyText;
  document.getElementById("headline").append(headline);
  document.getElementById("banner").src = picture;
}
