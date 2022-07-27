// DocSection: cm_api_v2_post_file
// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
// Using ES6 syntax
// Note that this approach works when using Node.js. See a worked example using the browser
import { ManagementClient } from '@kontent-ai/management-sdk';
import { readFileSync } from 'fs';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const data = readFileSync('which-brewing-fits-you-1080px.jpg');

const response = await client.uploadBinaryFile()
  .withData({
    binaryData: data,
    contentLength: data.byteLength,
    contentType: 'image/jpeg',
    filename: 'which-brewing-fits-you-1080px.jpg'
  })
  .toPromise();
// EndDocSection