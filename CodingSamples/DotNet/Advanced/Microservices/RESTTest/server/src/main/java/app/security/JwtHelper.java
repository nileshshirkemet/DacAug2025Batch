package app.security;

import java.security.SecureRandom;
import java.time.Instant;
import java.util.Date;

import javax.crypto.SecretKey;
import javax.crypto.spec.SecretKeySpec;

import io.jsonwebtoken.Jwts;

public class JwtHelper {
    
    private static final SecretKey key;

    static {
        byte[] bits = new byte[32];
        new SecureRandom().nextBytes(bits);
        key = new SecretKeySpec(bits, "HmacSHA256");
    }

    public static String createToken(String userId) {
        return Jwts.builder()
            .subject(userId)
            .expiration(Date.from(Instant.now().plusSeconds(20 * 60)))
            .signWith(key)
            .compact();
    }

    public static String validateToken(String token) {
        return Jwts.parser()
            .verifyWith(key)
            .build()
            .parseSignedClaims(token)
            .getPayload()
            .getSubject();
    }
}
