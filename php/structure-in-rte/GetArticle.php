<?php
// DocSection: structure_in_rte_retrieve_article
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php
// Retrieves a content item named 'My article'
$item = $client->getItem('my_article');

// Retrieves text from the 'body' Rich text element
$description = $item->body;
// EndDocSection
?>