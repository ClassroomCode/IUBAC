using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventfulLib
{
    public interface Observer
    {
        void Update(object subject);
    }
}
