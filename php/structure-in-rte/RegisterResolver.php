<?php
// DocSection: structure_in_rte_register_resolver
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php
$client = new DeliveryClient("<YOUR_PROJECT_ID>");
$client->inlineLinkedItemsResolver= new CustomLinkedItemsResolver(); 
// EndDocSection
?>