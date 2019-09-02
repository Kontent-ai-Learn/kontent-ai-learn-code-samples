// DocSection: preview_content_detect_environment
const KenticoCloud = require('kentico-cloud-delivery');

// TODO: Determine whether the app is running in a preview environment
const isPreview = ...;

const deliveryClient = new KenticoCloud.DeliveryClient({
    projectId: '<YOUR_PROJECT_ID',
    previewApiKey: '<YOUR_PREVIEW_API_KEY>',
    globalQueryConfig:  {
        usePreviewMode: isPreview, // uses preview mode by default
    },
    typeResolvers: []
});
// EndDocSection