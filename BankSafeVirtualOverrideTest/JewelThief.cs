using System;
using System.Collections.Generic;
using System.Text;

namespace BankSafeVirtualOverrideTest
{
    class JewelThief : Locksmith
    {
        private string stolenJewels;
        protected override void ReturnContents(string safeContents, SafeOwner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine($"The jewels are mine! I stole: {stolenJewels}");
        }
    }
}
