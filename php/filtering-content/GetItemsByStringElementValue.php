<?php
// DocSection: 
$items = $client->getItems((new QueryParams())
    // Gets items whose Title element value equals to "Hello World"
    ->equals("elements.title", "Hello World")
// EndDocSection
?>