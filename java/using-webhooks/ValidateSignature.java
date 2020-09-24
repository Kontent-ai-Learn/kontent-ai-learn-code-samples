// DocSection: webhooks_validate_signature
// Tip: Find more about Java SDK at https://docs.kontent.ai/java
import javax.crypto;
import javax.crypto.spec;
import javax.xml.bind;

// Example of generating the hash to verify the notification
public static String generateHash(String message, String secret) throws Exception {
    Mac sha256Hmac = Mac.getInstance("HmacSHA256");
    SecretKeySpec secretKeySpec = new SecretKeySpec(secret.getBytes(StandardCharsets.UTF_8), "HmacSHA256");
    sha256Hmac.init(secretKeySpec);

    return Base64.getEncoder().encodeToString(sha256Hmac.doFinal(message.getBytes(StandardCharsets.UTF_8)));
}
// EndDocSection