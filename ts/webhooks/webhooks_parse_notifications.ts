import { parseSignedWebhookResponse, SIGNATURE_HEADER, ParseResult, WebhookResponse } from '@kontent-ai/webhook-helper';

const parseWebhookRequest = async (
  request: Request,
  secret: string,
): Promise<ParseResult<WebhookResponse>> => {
  const signature = request.headers.get(SIGNATURE_HEADER) ?? "";
  const payload = await request.text();

  return parseSignedWebhookResponse({
    payload,
    secret,
    signature,
  });
};

const handleWebhook = async (request: Request) => {
  const result = await parseWebhookRequest(request, 'your-webhook-secret');

  if (!result.success) {
    return new Response(result.error.message, { status: 401 });
  }

  // use typed notifications
  result.data.notifications.forEach(notification => {
    if (notification.object_type === 'content_item') {
      console.log('Content item:', notification.data.system.name);
    }
  });

  return new Response('OK', { status: 200 });
};