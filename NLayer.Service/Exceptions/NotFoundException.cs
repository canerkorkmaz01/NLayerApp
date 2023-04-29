using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Exceptions
{
    public class NotFoundException:Exception 
    {
        public NotFoundException(string message):base(message)
        {
                
        }
    }
}
