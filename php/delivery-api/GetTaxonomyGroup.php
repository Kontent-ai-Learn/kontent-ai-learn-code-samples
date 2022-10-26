<?php
// DocSection: delivery_api_get_taxonomy_group
// Tip: Find more about PHP SDKs at https://kontent.ai/learn/php
// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kontent\Ai\Delivery\DeliveryClient;

$client = new DeliveryClient('<YOUR_PROJECT_ID>');

$taxonomyGroup = $client->getTaxonomy('personas');
// EndDocSection
?>