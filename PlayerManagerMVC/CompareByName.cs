using System;
using System.Collections.Generic;

namespace PlayerManagerMVC
{
    public class CompareByName : IComparer<Player>
    {
        private readonly bool ascending;

        public CompareByName(bool ascending)
        {
            this.ascending = ascending;
        }

        public int Compare(Player x, Player y)
        {
            if (ascending)
            {
                return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
            }
            else
            {
                return string.Compare(y.Name, x.Name, StringComparison.Ordinal);
            }
        }
    }
}
