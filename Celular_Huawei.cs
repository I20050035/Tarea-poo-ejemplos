using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea
{
    public class Celular_Huawei : Celular
    {
        protected string navegador;

        public string Navegador
        {
            get 
            { 
                return navegador;
            }
            set
            {
                navegador = value; 
            }
        }

        public Celular_Huawei () : base ()
        {
            navegador = "" ;
        }

        public override string ToString()
        {
            return navegador+" "+ base.ToString();
        }
    }
}
