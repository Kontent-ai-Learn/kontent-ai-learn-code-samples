// DocSection: structure_in_rte_register_resolver
<?php
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php

$client = new DeliveryClient("e6d2946e-0e24-003f-a397-9d2d458c6d6e");
$client->inlineLinkedItemsResolver= new CustomLinkedItemsResolver(); 
// EndDocSection