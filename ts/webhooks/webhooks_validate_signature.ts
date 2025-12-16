// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { isSignatureValid, SIGNATURE_HEADER } from '@kontent-ai/webhook-helper';

// Example of generating the hash to verify the notification
const isValidSignature = async (request: Request, secret: string) => {
  const signature = request.headers.get(SIGNATURE_HEADER);

  return signature ? isSignatureValid({
    payload: await request.text(), // Use raw body data from the request
    secret,
    signature,
  }) : false;
};