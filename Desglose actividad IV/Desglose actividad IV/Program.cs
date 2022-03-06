using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desglose_actividad_IV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public void dispensar(int monto)
        {
            int x2000 = 0;
            int x1000 = 0;
            int x500 = 0;
            int x200 = 0;
            int x100 = 0;
            int x50 = 0;
            string res;

            if ((monto % 50) > 0)
            {
                throw new Exception("El monto no es correcto");
            }

            while (monto >= 2000)
            {
                monto = monto - 2000;
                x2000 += 1;


                while (monto >= 1000)
                {
                    monto = monto - 1000;
                    x1000 += 1;
                }


                while (monto >= 500)
                {
                    monto = monto - 500;
                    x500 += 1;
                }

                while (monto >= 200)
                {
                    monto = monto - 200;
                    x200 += 1;
                }

                while (monto >= 100)
                {
                    monto = monto - 100;
                    x100 += 1;
                }

                while (monto >= 50)
                {
                    monto = monto - 50;
                    x50 += 1;
                }
                res = "el resultado es:";
                if (x2000 > 0)

                    res = res.ToString() + ", " + x2000 + "de 2000";
            }
        }
    }
}
