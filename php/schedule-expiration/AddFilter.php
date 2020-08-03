<?php
// DocSection: schedule_expiration_add_filter
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php
// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use \Datetime;
use Kentico\Kontent\Delivery\DeliveryClient;
use Kentico\Kontent\Delivery\QueryParams;

$client = new DeliveryClient('8d20758c-d74c-4f59-ae04-ee928c0816b7');

$items = $client->getItems((new QueryParams())
            ->equals('system.type', 'landing_page'));
 
$publishedItems = array_filter($items->items, function($item){
    $now = new DateTime();
    return
        ($item->ExpireAt > $now || is_null($item->ExpireAt));
    });
// EndDocSection
?>