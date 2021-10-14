using ByteBank_13;
using System;
using System.Collections.Generic;

namespace ByteBank_13.Comparators
{
    internal class CheckingAccountComparatorByAgency : IComparer<CheckingAccount>
    {
        public int Compare(CheckingAccount x, CheckingAccount y)
        {
            return x.Agency.CompareTo(y.Agency);

            // Equivalent to int CompareTo

            //if (x.Agency.Equals(y.Agency)) return 0;

            //if (x == null) return -1;

            //if (y == null) return 1;

            //if (x.Agency < y.Agency) return -1;

            //return 1;
        }
    }
}
