// DocSection: schedule_unpublishing_filter_by_date
<?php
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php

// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use \Datetime;
use Kentico\Kontent\Delivery\DeliveryClient;
use Kentico\Kontent\Delivery\QueryParams;

$client = new DeliveryClient('8d20758c-d74c-4f59-ae04-ee928c0816b7');

$now = date_format(new DateTime(),'Y-m-d\TH:i:s\Z');

$items = $client->getItems((new QueryParams())
    ->equals('system.type', 'article')
    ->greaterThan('elements.expire_at', $now));
// EndDocSection