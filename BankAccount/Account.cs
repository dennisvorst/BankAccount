using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountNS
{
    public class Account
    {
        /* IBAN countryu codes are https://nl.wikipedia.org/wiki/ISO_3166-1*/
        enum CountryCodes {NL, US}

        public Boolean isValid(string BankAccount)
        {
            return false;
        }
        public Boolean isElevenProof(string BankAccount)
        {
            return false;
        }
        public Boolean hasValidCountryCode(string CountryCode)
        {
            return System.Enum.IsDefined(typeof(CountryCodes), CountryCode);
        }

    }
}
