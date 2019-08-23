// DocSection: webhooks_validate_signature
const crypto = require('crypto');

const isValidSignature = (req, secret) => {
  const givenSignature = req.headers['x-kc-signature'];
  const computedSignature = crypto.createHmac('sha256', secret)
  	// Note: Use raw body data from the request, for example, by using body-parser
    .update(req.body)
    .digest();
  return crypto.timingSafeEqual(Buffer.from(givenSignature, 'base64'), computedSignature);
}
// EndDocSection