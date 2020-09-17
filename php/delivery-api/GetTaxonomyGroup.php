<?php
// DocSection: delivery_api_get_taxonomy_group
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php
// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kentico\Kontent\Delivery\DeliveryClient;

$client = new DeliveryClient('<YOUR_PROJECT_ID>');

$taxonomyGroup = $client->getTaxonomy('personas');
// EndDocSection
?>