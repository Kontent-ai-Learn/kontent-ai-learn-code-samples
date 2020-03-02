// DocSection: getting_content_order_items
<?php
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php

// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kentico\Kontent\Delivery\DeliveryClient;
use Kentico\Kontent\Delivery\QueryParams;

$client = new DeliveryClient('8d20758c-d74c-4f59-ae04-ee928c0816b7');

$items = $client->getItems((new QueryParams())
            ->equals('system.type', 'article')
            ->limit(3)
            ->orderDesc('system.last_modified'));
// EndDocSection