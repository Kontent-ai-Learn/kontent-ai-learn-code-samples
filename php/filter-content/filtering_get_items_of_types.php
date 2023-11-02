<?php
// Gets items based on the types Product, Article, and News
$items = $deliveryClient->getItems((new QueryParams())
  ->in('system.type', ['product', 'article', 'news']));
?>