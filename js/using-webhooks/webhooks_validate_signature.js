// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
const signatureHelper = require('@kontent-ai/webhook-helper');

// Generates a payload hash and compares it to the payload signature
const isValidSignature = (req, secret) => {
  return signatureHelper.isValidSignatureFromString(
    req.body, // Use raw body data from the request, i.e., by using body-parser
    secret,
    req.headers['x-kontent-ai-signature']
  );
};