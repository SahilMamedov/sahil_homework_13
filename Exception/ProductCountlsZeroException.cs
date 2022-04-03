using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_13
{
    class ProductCountlsZeroException:Exception
    {

        public ProductCountlsZeroException(string message):base(message)
        {

        }
    }
}
