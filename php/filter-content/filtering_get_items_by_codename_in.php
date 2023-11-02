<?php
// Gets three items by their codenames. The codenames are unique per project.
$items = $client->getItems((new QueryParams())
  ->in('system.codename', ['delivery_api', 'get_content', 'hello_world']));
?>