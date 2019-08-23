// DocSection: managing_navigation_articles_slugs
<?php

// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use KenticoCloud\Delivery\DeliveryClient;
use KenticoCloud\Delivery\QueryParams;

$client = new DeliveryClient('975bf280-fd91-488c-994c-2f04416e5ee3');

$items = $client->getItems((new QueryParams())
            ->equals('system.type', 'article')
            ->elements(array("title", "url_pattern")));
// EndDocSection