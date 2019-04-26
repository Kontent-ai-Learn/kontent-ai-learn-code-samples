// DocSection: preview_content_detect_environment
import com.kenticocloud.delivery;

// TODO: Determine whether the app is running in a preview environment
boolean isPreview = ...;

DeliveryOptions deliveryOptions = new DeliveryOptions();
deliveryOptions.setProjectId("<YOUR_PROJECT_ID>");
deliveryOptions.setPreviewApiKey("<YOUR_PREVIEW_API_KEY>");
deliveryOptions.setUsePreviewApi(isPreview ? true : false);

DeliveryClient client = new DeliveryClient(deliveryOptions);
// EndDocSection