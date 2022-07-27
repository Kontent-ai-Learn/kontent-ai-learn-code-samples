// DocSection: importing_assets_upload_file
// Using ES6 syntax
// This approach works when using Node.js.
import { ManagementClient } from '@kontent-ai/management-sdk';
import { readFileSync } from 'fs'

const client = new ManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const data = readFileSync('./<YOUR_PATH>/brno-cafe-1080px.jpg');

const response = await client.uploadBinaryFile()
  .withData({
    binaryData: data,
    contentLength: data.byteLength,
    contentType: 'image/jpeg',
    filename: 'brno-cafe-1080px.jpg'
  })
  .toPromise();
// EndDocSection