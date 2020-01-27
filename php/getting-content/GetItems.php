// DocSection: getting_content_get_items
<?php
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php

// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kentico\Kontent\Delivery\DeliveryClient;

$client = new DeliveryClient('8d20758c-d74c-4f59-ae04-ee928c0816b');

$items = $client->getItems();
// EndDocSection