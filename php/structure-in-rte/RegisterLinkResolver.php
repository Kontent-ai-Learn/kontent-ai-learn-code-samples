<?php
// DocSection: structure_in_rte_register_link_resolver
// Tip: Find more about PHP SDKs at https://kontent.ai/learn/php
$client = new DeliveryClient("<YOUR_ENVIRONMENT_ID>");
$client->contentLinkUrlResolver = new CustomContentLinkUrlResolver(); 
// EndDocSection
?>