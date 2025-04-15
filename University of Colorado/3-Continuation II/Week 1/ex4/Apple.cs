using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Apple
    {
        #region Fields

        float amountLeft;
        bool organic;

        #endregion

        #region Properties

        public float AmountLeft
        {
            get { return amountLeft; }
        }

        public bool Organic
        {
            get { return organic; }
        }
        #endregion
    }
}
