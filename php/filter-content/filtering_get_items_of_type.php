<?php
// Gets items based on the type Product
$items = $deliveryClient->getItems((new QueryParams())
  ->equals('system.type', 'product'));
?>