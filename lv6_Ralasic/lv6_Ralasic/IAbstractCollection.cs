using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv6_Ralasic
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
