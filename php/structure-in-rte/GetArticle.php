// DocSection: structure_in_rte_retrieve_article
<?php
// Retrieves the 'The Origin of Coffee' article
$item = $client->getItem('the_origin_of_coffee');

// Retrieves text from the 'body' Rich text element
$description = $item->body;
// EndDocSection