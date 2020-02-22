using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;

namespace UnitTestBankAccount
{

    [TestClass]
    public class BankAccountTests
    {

        [TestMethod]
        public void BankAccount_is_valid()
        {
            /* iban generated using https://www.mobilefish.com/services/random_iban_generator/random_iban_generator.php*/
            Account ba = new Account();
            Assert.IsTrue(ba.isValid("AD1200012030200359100100"));
        }

        [TestMethod]
        public void BankAccount_is_invalid()
        {
            //isValid("XX9449410484356647594831");
            Account ba = new Account();
            Assert.IsFalse(ba.isValid("XX9449410484356647594831"));
        }

        [TestMethod]
        public void CountryCode_is_valid()
        {
            Account ba = new Account();
            Assert.IsTrue(ba.hasValidCountryCode("NL"));
        }

        [TestMethod]
        public void CountryCode_is_invalid()
        {
            Account ba = new Account();
            Assert.IsFalse(ba.hasValidCountryCode("XX"));
        }

        [TestMethod]
        public void AccountNummber_is_11proof()
        {
            /* NL60ABNA0303221674 */
            //            isElevenProof(*"0303221673");
  //          Account ba = new Account();
//            Assert.IsTrue(ba.isElevenProof(*"0303221673"));
            Assert.Fail();
        }
        [TestMethod]
        public void AccountNummber_is_not_11proof()
        {
            /* NL60ABNA0303221674 */
            //            isElevenProof(*"0303221674");
//            Account ba = new Account();
            //Assert.IsTrue(ba.isElevenProof(*"0303221673"));
            Assert.Fail();
        }
    }
}
