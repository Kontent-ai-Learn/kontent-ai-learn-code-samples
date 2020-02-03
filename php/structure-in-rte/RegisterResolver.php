// DocSection: structure_in_rte_register_resolver
<?php
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php

$client = new DeliveryClient("8d20758c-d74c-4f59-ae04-ee928c0816b7");
$client->inlineLinkedItemsResolver= new CustomLinkedItemsResolver(); 
// EndDocSection