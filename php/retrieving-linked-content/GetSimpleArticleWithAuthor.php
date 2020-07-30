<?php
// DocSection: linked_content_get_article_with_author
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php
// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kentico\Kontent\Delivery\DeliveryClient;

$client = new DeliveryClient('8d20758c-d74c-4f59-ae04-ee928c0816b7');

$item = $client->getItem('the_origin_of_coffee', (new QueryParams())
            ->depth(1));
// EndDocSection
?>