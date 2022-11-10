<?php
// DocSection: getting_content_order_items
// Tip: Find more about PHP SDKs at https://kontent.ai/learn/php
// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kontent\Ai\Delivery\DeliveryClient;

$client = new DeliveryClient('8d20758c-d74c-4f59-ae04-ee928c0816b7');

$items = $client->getItems((new QueryParams())
            ->equals('system.type', 'article')
            ->limit(3)
            ->orderDesc('system.last_modified'));
// EndDocSection
?>