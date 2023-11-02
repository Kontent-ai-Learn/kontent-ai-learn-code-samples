// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import KontentSmartLink, { KontentSmartLinkEvent } from '@kontent-ai/smart-link';

const sdk = KontentSmartLink.initialize({ ... });

sdk.on(
  KontentSmartLinkEvent.Refresh,
  (data, metadata, originalRefresh) => {
    // Custom refresh logic goes here
    // ...
    originalRefresh(); // If you want to refresh the page at the end
  }
);
