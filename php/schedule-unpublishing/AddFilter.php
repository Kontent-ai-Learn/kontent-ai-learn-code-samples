// DocSection: schedule_unpublishing_add_filter
<?php

// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use \Datetime;
use KenticoCloud\Delivery\DeliveryClient;
use KenticoCloud\Delivery\QueryParams;

$client = new DeliveryClient('14372844-0a5d-434a-8423-605b8a631623');

$items = $client->getItems((new QueryParams())
            ->equals('system.type', 'article'));
 
$publishedArticles = array_filter($items->items, function($item){
    $now = new DateTime();
    return
        ($item->publishUntil > $now || is_null($item->publishUntil));
    });
// EndDocSection