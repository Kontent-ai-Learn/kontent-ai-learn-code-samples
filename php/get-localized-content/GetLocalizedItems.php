<?php
// DocSection: getting_localized_content_language
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php
// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kentico\Kontent\Delivery\DeliveryClient;
use Kentico\Kontent\Delivery\QueryParams;

$client = new DeliveryClient('8d20758c-d74c-4f59-ae04-ee928c0816b7');

$items = client->getItem('about_us', (new QueryParams())
            ->language('es-ES'));
// EndDocSection
?>