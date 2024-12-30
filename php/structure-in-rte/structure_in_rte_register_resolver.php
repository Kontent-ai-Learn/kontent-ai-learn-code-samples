<?php
// Tip: Find more about PHP SDKs at https://kontent.ai/learn/php
$client = new DeliveryClient("KONTENT_AI_ENVIRONMENT_ID");
$client->inlineLinkedItemsResolver= new CustomLinkedItemsResolver(); 
?>