# Passlib.PBKDF2WithHmacSHA512.NET
A quick project to show how to verify a Passlib pdkdf2 sha512 hash in .Net

Uses the Derive Bytes implementation from JimmiTh on [Stack Overflow](http://stackoverflow.com/a/22119356/2477669) and the tips from zaph also on [Stack Overflow](http://stackoverflow.com/a/39169566/2477669).

Can be used to verify passwords generated by Passlib using the $pbkdf2-sha512$ algorithm.

To use just call GenerateComparableHash.VerifyNonstandardHash(password, hash).
