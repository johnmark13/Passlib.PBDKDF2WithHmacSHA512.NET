using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPbkdf2Sha512
{
    [TestClass]
    public class GenerateComparableHashTests
    {

        [TestMethod]
        public void KnownValueProducesKnownHash()
        {
            string password = "Testing123";
            var hash = "$pbkdf2-sha512$10001$2ZuTslYKAYDQGiPkfA.B8A$ChsEXEjanEToQcPJiuVaKk0Ls3n0YK7gnxsu59rxWOawl/iKgo0XSWyaAfhFV0.Yu3QqfehB4dc7yGGsIW.ARQ";

            var components = hash.Split('$');
            var algo = components[1];
            var iterations = components[2];
            var rawsalt = components[3];
            var rawhash = components[4];

            String salt = GenerateComparableHash.StandardiseBase64(rawsalt);

            string regenerated = GenerateComparableHash.Generate64BitHash(password, salt, int.Parse(iterations));
            string destandardised = GenerateComparableHash.DestandardiseBase64(regenerated);

            Assert.AreEqual(rawhash, destandardised);
        }
    }
}
