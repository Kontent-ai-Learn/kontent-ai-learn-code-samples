<?php
// DocSection: delivery_api_get_types
// Tip: Find more about PHP SDKs at https://kontent.ai/learn/php
// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kontent\Ai\Delivery\DeliveryClient;

$client = new DeliveryClient('<YOUR_PROJECT_ID>');

$types = $client->getTypes((new QueryParams())
            ->limit(3));
// EndDocSection
?>