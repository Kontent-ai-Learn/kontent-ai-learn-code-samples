<?php
// DocSection: securing_public_access_get_article
// Tip: Find more about PHP SDKs at https://kontent.ai/learn/php
// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kontent\Ai\Delivery\DeliveryClient;

$client = new DeliveryClient('<YOUR_PROJECT_ID>', null, '<YOUR_API_KEY>');

$item = $client->getItem('my_article');
// EndDocSection
?>