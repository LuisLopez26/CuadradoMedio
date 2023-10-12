using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuadradoMedio.Algoritmos
{
    public class AlgoritmoGenerador
    {
        public List<int> lista = new List<int>();

        public List<int> AlgoritmoCuadradoMedio(int n)
        {
            List<int> listaSalida = new List<int>();
            

            while (n != 0)
            {
                listaSalida.Add(n);
                n = (int)Math.Pow(n, 2);
                listaSalida.Add(n);
                string nString = n.ToString();
                string sinPrimerYUltimo = nString.Substring(1, nString.Length - 2);
                n = int.Parse(sinPrimerYUltimo);
                listaSalida.Add(n);
                nString = n.ToString();

                if (nString.Length > 3)
                {
                    string val1 = nString.Substring(0, 3);
                    string val2 = nString.Substring(nString.Length - 3);
                    n = int.Parse(val1);
                    listaSalida.Add(n);
                    n = int.Parse(val2);
                    listaSalida.Add(n);
                    n = int.Parse(val1);

                }
                else
                {
                    n = int.Parse(nString);
                    listaSalida.Add(n);
                    listaSalida.Add(0);

                }


            }

            MessageBox.Show("Se detuvo el programa por convergencia.");

            return listaSalida;
        }






    }
}
