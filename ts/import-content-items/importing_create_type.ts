// Tip: Find more about JS/TS SDKs at https://kontent.ai/learn/javascript
import { ManagementClient } from '@kontent-ai/management-sdk';

const client = new ManagementClient({
    environmentId: 'KONTENT_AI_ENVIRONMENT_ID',
    apiKey: 'KONTENT_AI_MANAGEMENT_API_KEY'
});

const response = await client
    .addContentType()
    .withData((builder) => {
        return {
            codename: 'cafe',
            name: 'Cafe',
            external_id: 'cafe',
            elements: [
                builder.numberElement({
                    name: 'Price per unit',
                    type: 'number',
                    codename: 'price_per_unit'
                }),
                builder.guidelinesElement({
                    guidelines:
                        '<h2>Keep Guidelines where the creative process happens.</h2>\n<p>These are sample guidelines that you can place for the whole content item. It’s a place where you can include your content brief, voice and tone recommendations or the URL to a wireframe, so the author will have all the relevant instructions at hand before writing a single line.</p>\n<p>Besides overview guidelines, you can include instructions for each particular content element, as you will see below.</p>',
                    type: 'guidelines',
                    codename: 'n2f836bce_e062_b2cd_5265_f5c3be3aa6f5'
                }),
                builder.textElement({
                    name: 'Street',
                    type: 'text',
                    codename: 'street'
                }),

                builder.textElement({
                    name: 'City',
                    type: 'text',
                    codename: 'city'
                }),
                builder.textElement({
                    name: 'Country',
                    type: 'text',
                    codename: 'country'
                }),
                builder.textElement({
                    name: 'State',
                    type: 'text',
                    codename: 'state'
                }),
                builder.textElement({
                    name: 'ZIP Code',
                    type: 'text',
                    codename: 'zip_code'
                }),
                builder.textElement({
                    name: 'Phone',
                    type: 'text',
                    codename: 'phone'
                }),
                builder.textElement({
                    name: 'Email',
                    type: 'text',
                    codename: 'email'
                }),
                builder.assetElement({
                    name: 'Photo',
                    type: 'asset',
                    codename: 'photo'
                })
            ]
        };
    })
    .toPromise();