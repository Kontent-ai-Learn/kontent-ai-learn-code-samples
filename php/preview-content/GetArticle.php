<?php
// DocSection: preview_content_get_article
// Tip: Find more about PHP SDKs at https://kontent.ai/learn/php
// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kontent\Ai\Delivery\DeliveryClient;

$client = new DeliveryClient('<YOUR_PROJECT_ID>', '<YOUR_PREVIEW_API_KEY>');

$item = $client->getItem('my_article');
// EndDocSection
?>