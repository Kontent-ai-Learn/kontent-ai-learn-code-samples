<?php
// DocSection: managing_navigation_articles_slugs
// Tip: Find more about PHP SDKs at https://kontent.ai/learn/php
// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kontent\Ai\Delivery\DeliveryClient;

$client = new DeliveryClient('8d20758c-d74c-4f59-ae04-ee928c0816b7');

// Gets navigation items and their linked items
$root = $client->getItem('root_navigation_item', (new QueryParams())
            ->depth(5));

// Gets specific elements of all articles
$articles = $client->getItems((new QueryParams())
            ->equals('system.type', 'article')
            ->elements(array("title", "url")));
// EndDocSection
?>