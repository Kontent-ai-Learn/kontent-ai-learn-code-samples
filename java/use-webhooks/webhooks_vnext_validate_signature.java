// Tip: Find more about Java SDK at https://kontent.ai/learn/java
import javax.crypto;
import javax.crypto.spec;
import javax.xml.bind;

// Generates a payload hash to compare with the 'X-Kontent-ai-Signature' header value
public static String generateHash(String message, String secret) throws Exception {
    Mac sha256Hmac = Mac.getInstance("HmacSHA256");
    SecretKeySpec secretKeySpec = new SecretKeySpec(secret.getBytes(StandardCharsets.UTF_8), "HmacSHA256");
    sha256Hmac.init(secretKeySpec);

    return Base64.getEncoder().encodeToString(sha256Hmac.doFinal(message.getBytes(StandardCharsets.UTF_8)));
}
