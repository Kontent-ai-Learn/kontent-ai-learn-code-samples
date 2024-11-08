// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { IContentItem, Elements } from '@kontent-ai/delivery-sdk';

export type Homepage = IContentItem<{
  headline: Elements.TextElement;
  body_text: Elements.RichTextElement;
  picture: Elements.AssetsElement;
}>;