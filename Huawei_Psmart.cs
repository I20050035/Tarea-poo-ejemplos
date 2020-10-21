using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea
{
    public class Huawei_Psmart : Celular_Huawei
    {
        protected string año;

        public string Año
        {
            get
            {
                return año; 
            }
            set 
            { 
                año = value; 
            }
        }

        public Huawei_Psmart (): base ()
        {
            año = "";
      }

        public override string ToString()
        {
            return año +""+ base.ToString();
        }

    }
}
