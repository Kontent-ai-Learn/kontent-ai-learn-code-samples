// DocSection: cm_api_v2_post_file
// Tip: Find more about JS/TS SDKs at https://docs.kontent.ai/javascript
// Using ES6 syntax
// Note that this approach works when using Node.js. See a worked example using the browser: https://github.com/Enngage/@kentico/kontent-management-js-demo
import { ManagementClient } from '@kentico/kontent-management';
import { readFileSync } from 'fs';

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const data = readFileSync('which-brewing-fits-you-1080px.jpg');

client.uploadBinaryFile()
  .withData({
    binaryData: data,
    contentLength: data.byteLength,
    contentType: 'image/jpg',
    filename: 'which-brewing-fits-you-1080px.jpg'
  })
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
  (error) => {
    console.log(error);
  });
// EndDocSection