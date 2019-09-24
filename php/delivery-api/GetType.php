// DocSection: delivery_api_get_type
<?php
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php

// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kentico\Kontent\Delivery\DeliveryClient;

$client = new DeliveryClient('975bf280-fd91-488c-994c-2f04416e5ee3');

$type = $client->getType('coffee');
// EndDocSection