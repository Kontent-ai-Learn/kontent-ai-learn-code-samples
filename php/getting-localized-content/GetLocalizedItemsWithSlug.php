// DocSection: getting_localized_content_url_slug
<?php
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php

// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use Kentico\Kontent\Delivery\DeliveryClient;
use Kentico\Kontent\Delivery\QueryParams;

$client = new DeliveryClient('8d20758c-d74c-4f59-ae04-ee928c0816b');

$items = $client->getItems((new QueryParams())
            ->language('es-ES')
            ->equals('system.type', 'article')
            ->equals('elements.url_pattern', 'acerda-de-nosotros'));
// EndDocSection