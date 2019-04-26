// DocSection: preview_content_detect_environment
import { DeliveryClient } from 'kentico-cloud-delivery';

// TODO: Determine whether the app is running in a preview environment
const isPreview = ...;

const deliveryClient = new DeliveryClient({
    projectId: '<YOUR_PROJECT_ID',
    enablePreviewMode: isPreview,
    previewApiKey: "<YOUR_PREVIEW_API_KEY>",
    typeResolvers: []
});
// EndDocSection