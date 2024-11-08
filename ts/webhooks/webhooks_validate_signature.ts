// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { signatureHelper } from '@kontent-ai/webhook-helper';

// Example of generating the hash to verify the notification
const isValidSignature = (req, secret) => {
  return signatureHelper.isValidSignatureFromString(
    req.body, // Use raw body data from the request, i.e., by using body-parser
    secret,
    req.headers['x-kontent-ai-signature']
  );
};