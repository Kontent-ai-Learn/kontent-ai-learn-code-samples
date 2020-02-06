// DocSection: delivery_api_get_item
<?php
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php

// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kentico\Kontent\Delivery\DeliveryClient;

$client = new DeliveryClient('<YOUR_PROJECT_ID>');

$item = $client->getItem('on_roasts', (new QueryParams())
            ->elements(array('title', 'summary', 'post_date','teaser_image', 'related_articles')));
// EndDocSection