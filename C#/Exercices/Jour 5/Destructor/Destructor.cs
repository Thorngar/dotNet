using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    class Destructor:IDisposable
    {
        public Destructor()
        {
            Console.WriteLine("Test");
        }

        ~Destructor()
        {
            Console.WriteLine("Destruction");
        }

        public void Dispose()
        {
            Dispose(true);
        }
        protected void Dispose(bool isDisposing)
        {
            Dispose(false);       
        }
    }
}
