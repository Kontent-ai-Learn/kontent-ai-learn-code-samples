// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import KontentSmartLink, { KontentSmartLinkEvent } from '@kontent-ai/smart-link';

// 
const sdk = KontentSmartLink.initialize({
  defaultDataAttributes: {
    environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
    languageCodename: 'default',
  },
});

sdk.on(
  KontentSmartLinkEvent.Refresh,
  (data, metadata, originalRefresh) => {
    // Place for your custom refresh logic
    originalRefresh(); // If you want to refresh the page at the end
  }
);
