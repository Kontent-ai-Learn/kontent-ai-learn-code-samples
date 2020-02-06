// DocSection: delivery_api_get_item_preview
<?php
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php

// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kentico\Kontent\Delivery\DeliveryClient;

$client = new DeliveryClient('<YOUR_PROJECT_ID>', '<YOUR_PREVIEW_API_KEY>');

$item = $client->getItem('on_roasts');
// EndDocSection