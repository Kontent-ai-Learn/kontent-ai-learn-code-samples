<?php
// DocSection: delivery_api_get_item
// Tip: Find more about PHP SDKs at https://kontent.ai/learn/php
// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kontent\Ai\Delivery\DeliveryClient;

$client = new DeliveryClient('<YOUR_PROJECT_ID>');

$item = $client->getItem('my_article', (new QueryParams()));
// EndDocSection
?>