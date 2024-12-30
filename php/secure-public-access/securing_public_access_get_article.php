<?php
// Tip: Find more about PHP SDKs at https://kontent.ai/learn/php
// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kontent\Ai\Delivery\DeliveryClient;

$client = new DeliveryClient('KONTENT_AI_ENVIRONMENT_ID', null, 'KONTENT_AI_DELIVERY_API_KEY');

$item = $client->getItem('my_article');
?>