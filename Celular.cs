using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea
{
    public class Celular
    {
        protected int memoria;

        public int Memoria
        {
            get
            { 
                return memoria; 
            }
            set 
            { 
                memoria = value; 
            }
        }
             
        public Celular() 
        {
            memoria = 0;
            
        }

        public override string ToString()
        {
            return memoria + "Gb";
        }
    }
}
