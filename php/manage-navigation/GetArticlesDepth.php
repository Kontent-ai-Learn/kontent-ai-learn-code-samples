<?php
// DocSection: managing_navigation_articles_depth
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php
// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kentico\Kontent\Delivery\DeliveryClient;

$client = new DeliveryClient('8d20758c-d74c-4f59-ae04-ee928c0816b7');

$item = $client->getItem('root_navigation_item', (new QueryParams())
            ->depth(5));
// EndDocSection
?>