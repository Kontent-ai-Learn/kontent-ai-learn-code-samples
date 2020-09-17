// DocSection: webhooks_validate_signature
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
const signatureHelper = require('@kentico/kontent-webhook-helper');

// Example of generating the hash to verify the notification
const isValidSignature = (req, secret) => {
  return signatureHelper(
    req.body, // Use raw body data from the request, i.e., by using body-parser
    secret,
    req.headers['x-kc-signature']
  );
};
// EndDocSection