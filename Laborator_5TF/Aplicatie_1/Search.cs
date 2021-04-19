using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie_1
{
    public class Search
    {
        public void Run(AbstractTest test)
        {
            test.Initialize();
            test.Search();
        }
    }
}
