// DocSection: preview_content_get_article
<?php

// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use KenticoCloud\Delivery\DeliveryClient;

$client = new DeliveryClient('<YOUR_PROJECT_ID>', '<YOUR_PREVIEW_API_KEY>');

$item = $client->getItem('on_roasts');
// EndDocSection