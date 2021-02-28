using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventfulLib
{
    public class BillingService
    {
        public void Update(object subject)
        {
            if (subject is Album)
            {
                GenerateCharge((Album)subject);
            }
        }

        private void GenerateCharge(Album album)
        {
            //code to generate charge for correct album
        }
    }
}
