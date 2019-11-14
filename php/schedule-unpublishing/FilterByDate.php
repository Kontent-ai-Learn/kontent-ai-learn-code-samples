// DocSection: schedule_unpublishing_filter_by_date
<?php
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php

// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use \Datetime;
use Kentico\Kontent\Delivery\DeliveryClient;
use Kentico\Kontent\Delivery\QueryParams;

$client = new DeliveryClient('14372844-0a5d-434a-8423-605b8a631623');

$now = date_format(new DateTime(),'Y-m-d\TH:i:s\Z');

$items = $client->getItems((new QueryParams())
    ->equals('system.type', 'article')
    ->greaterThan('elements.publish_until', $now));
// EndDocSection