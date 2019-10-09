// DocSection: importing_assets_upload_file
// Using ES6 syntax
// Note that this approach works when using Node.js. See a worked example using the browser: https://github.com/Enngage/kentico-cloud-content-management-js-demo
import { ContentManagementClient } from 'kentico-cloud-content-management';
import { readFileSync } from 'fs'

const client = new ContentManagementClient({
  projectId: '<YOUR_PROJECT_ID>',
  apiKey: '<YOUR_API_KEY>'
});

const data = readFileSync('brno-cafe-1080px.jpg');

client.uploadBinaryFile()
  .withData({
    binaryData: data,
    contentLength: data.byteLength,
    contentType: 'image/jpg',
    filename: 'brno-cafe-1080px.jpg'
  })
  .toObservable()
  .subscribe((response) => {
    console.log(response);
  },
    (error) => {
      console.log(error);
    });
// EndDocSection