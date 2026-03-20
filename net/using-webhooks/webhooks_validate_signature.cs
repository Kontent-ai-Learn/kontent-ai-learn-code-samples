// Tip: Find more about .NET SDKs at https://kontent.ai/learn/net
using System;
using System.Security.Cryptography;
using System.Text;

// Validates the 'X-Kontent-ai-Signature' header against the raw webhook payload.
static bool IsWebhookSignatureValid(string payload, string sharedSecret, string signatureHeader)
{
    if (string.IsNullOrWhiteSpace(signatureHeader))
    {
        return false;
    }

    // Header values can be quoted depending on hosting pipeline/proxy behavior.
    var normalizedSignature = signatureHeader.Trim().Trim('"');

    var payloadBytes = Encoding.UTF8.GetBytes(payload ?? string.Empty);
    var keyBytes = Encoding.UTF8.GetBytes(sharedSecret ?? string.Empty);

    using var hmac = new HMACSHA256(keyBytes);
    var computedBytes = hmac.ComputeHash(payloadBytes);
    var computedSignature = Convert.ToBase64String(computedBytes);

    // Use constant-time comparison to avoid timing attacks.
    var providedBytes = Encoding.UTF8.GetBytes(normalizedSignature);
    var expectedBytes = Encoding.UTF8.GetBytes(computedSignature);
    return CryptographicOperations.FixedTimeEquals(providedBytes, expectedBytes);
}