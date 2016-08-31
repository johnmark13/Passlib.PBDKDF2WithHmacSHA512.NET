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

            var equal = GenerateComparableHash.VerifyNonstandardHash(password, hash);
            Assert.IsTrue(equal);
        }
    }
}
