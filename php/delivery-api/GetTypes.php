// DocSection: delivery_api_get_types
<?php
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php

// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kentico\Kontent\Delivery\DeliveryClient;
use Kentico\Kontent\Delivery\QueryParams;

$client = new DeliveryClient('<YOUR_PROJECT_ID>');

$types = $client->getTypes((new QueryParams())
            ->limit(3));
// EndDocSection