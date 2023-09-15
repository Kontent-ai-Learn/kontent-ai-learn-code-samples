<?php
// DocSection: structure_in_rte_register_resolver
// Tip: Find more about PHP SDKs at https://kontent.ai/learn/php
$client = new DeliveryClient("<YOUR_ENVIRONMENT_ID>");
$client->inlineLinkedItemsResolver= new CustomLinkedItemsResolver(); 
// EndDocSection
?>