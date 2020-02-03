// DocSection: sharing_project_content_get_items
<?php
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php

// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kentico\Kontent\Delivery\DeliveryClient;

// Initializes the content delivery clients
$client1 = new DeliveryClient("975bf280-fd91-488c-994c-2f04416e5ee3");
$client2 = new DeliveryClient("8d20758c-d74c-4f59-ae04-ee928c0816b7");

// Gets content items from both projects
$items1 = $client1->getItems();
$items2 = $client2->getItems();

$items = array_merge($items1, $items2);
// EndDocSection