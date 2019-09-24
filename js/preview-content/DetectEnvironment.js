// DocSection: preview_content_detect_environment
const KontentDelivery = require('@kentico/kontent-delivery');

// TODO: Determine whether the app is running in a preview environment
const isPreview = ...;

const deliveryClient = new KontentDelivery.DeliveryClient({
    projectId: '<YOUR_PROJECT_ID',
    previewApiKey: '<YOUR_PREVIEW_API_KEY>',
    globalQueryConfig:  {
        usePreviewMode: isPreview, // Queries the Delivery Preview API.
    },
    typeResolvers: []
});
// EndDocSection