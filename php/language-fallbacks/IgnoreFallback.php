// DocSection: language_fallbacks_ignore
<?php

// Defined by Composer to include required libraries
require __DIR__ . '/vendor/autoload.php';

use KenticoCloud\Delivery\DeliveryClient;

$client = new DeliveryClient('975bf280-fd91-488c-994c-2f04416e5ee3');

$items = $client->getItems((new QueryParams())
            ->language('es-ES')
            ->equals('system.language', 'es-ES');
// EndDocSection
