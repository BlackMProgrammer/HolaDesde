using System;
using System.Collections.Generic;
using System.Text;

namespace HolaDesde
{
    class Padre
    {
        protected Padre()
        {

        }
        public virtual void ShowMessage() => Console.WriteLine("Hola desde la Clase padre");
    }
}
