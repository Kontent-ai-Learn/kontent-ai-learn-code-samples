// DocSection: structure_in_rte_retrieve_article
<?php
// Tip: Find more about PHP SDKs at https://docs.kontent.ai/php

// Retrieves the 'Coffee Beverages Explained' article
$item = $client->getItem('coffee_beverages_explained');

// Retrieves text from the 'body' Rich text element
$description = $item->body;
// EndDocSection
