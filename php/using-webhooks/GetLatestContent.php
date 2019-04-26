// DocSection: using_webhooks_get_latest_content
<?php

// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use KenticoCloud\Delivery\DeliveryClient;

$client = new DeliveryClient("<YOUR_PROJECT_ID>", null, true);

$item = client->getItem('on_roasts');
// EndDocSection