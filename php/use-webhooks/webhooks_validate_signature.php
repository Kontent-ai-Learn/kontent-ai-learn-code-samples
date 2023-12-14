<?php
// Example of generating the hash to verify the notification
$givenSignature = $_SERVER['HTTP_X_KONTENT_AI_SIGNATURE'];
$computedSignature = base64_encode(hash_hmac('sha256', $json_message, $secret, true));

$result = hash_equals($givenSignature, $computedSignature);
?>