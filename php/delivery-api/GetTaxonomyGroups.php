// DocSection: delivery_api_get_taxonomy_groups
<?php
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php

// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kentico\Kontent\Delivery\DeliveryClient;
use Kentico\Kontent\Delivery\QueryParams;

$client = new DeliveryClient('975bf280-fd91-488c-994c-2f04416e5ee3');

$taxonomyGroups = $client->getTaxonomies((new QueryParams())
            ->limit(3));
// EndDocSection