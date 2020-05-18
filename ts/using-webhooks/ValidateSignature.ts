// DocSection: webhooks_validate_signature
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
import { signatureHelper } from '@kentico/kontent-webhook-helper';

// Note: Use raw body data from the request, for example, by using body-parser
const isValidSignature = (req, secret) => {
    return signatureHelper(req.body, secret, req.headers['x-kc-signature']);
};
// EndDocSection