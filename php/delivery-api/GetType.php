<?php
// DocSection: delivery_api_get_type
// Tip: Find more about PHP SDKs at https://kontent.ai/learn/php
// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kentico\Kontent\Delivery\DeliveryClient;

$client = new DeliveryClient('<YOUR_PROJECT_ID>');

$type = $client->getType('article');
// EndDocSection
?>