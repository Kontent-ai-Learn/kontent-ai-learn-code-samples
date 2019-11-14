// DocSection: preview_content_detect_environment
// Tip: Find more about Swift SDK at https://docs.kontent.ai/ios
import KenticoCloud

// TODO: Determine whether the app is running in a preview environment
let isPreview = ...

let previewKey = isPreview ? "<YOUR_PREVIEW_API_KEY>" : nil

let client = DeliveryClient.init(projectId: "<YOUR_PROJECT_ID>", apiKey: previewKey)
// EndDocSection