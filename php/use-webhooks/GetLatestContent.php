<?php
// DocSection: using_webhooks_get_latest_content
// Tip: Find more about PHP SDKs at https://kontent.ai/learn/php
// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kentico\Kontent\Delivery\DeliveryClient;

$client = new DeliveryClient("<YOUR_PROJECT_ID>", null, true);

$item = client->getItem('my_article');
// EndDocSection
?>