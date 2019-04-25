// DocSection: getting_localized_content_language
<?php

// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use KenticoCloud\Delivery\DeliveryClient;
use KenticoCloud\Delivery\QueryParams;

$client = new DeliveryClient('975bf280-fd91-488c-994c-2f04416e5ee3');

$items = client->getItem('on_roasts', (new QueryParams())
            ->language('es-ES'));
// EndDocSection