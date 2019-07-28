using System;
using System.Collections.Generic;
using System.Text;

namespace FelizesESortudos.Servico
{
    class TestaNumero
    {
        /// <summary>
        /// Testa se o número é feliz
        /// </summary>
        /// <param name="val"></param>
        /// <returns>True se o número for feliz, do contrário retorna False</returns>
        private static bool IsFeliz(double val)
        {
            for(int x=0;x<100;x++)
            {
                var lstNum = val.ToString().ToCharArray();
                double res = 0;
                foreach (var item in lstNum)
                {
                    res += Math.Pow(Double.Parse(item.ToString()), Double.Parse(2.ToString()));
                }
                if (res == 1)
                {
                    Console.WriteLine("IsFeliz: " + true);
                    return true;
                }
                else
                {
                    val = res;
                }
            }
            Console.WriteLine("IsFeliz: " + false);
            return false;
        }

        /// <summary>
        /// Testa se o número é Sortudo
        /// </summary>
        /// <param name="val"></param>
        /// <returns>True se o número for sortudo, do contrário retorna False</returns>
        private static bool IsSortudo(double val)
        {
            List<double> lst = new List<double>();
            for (int x=1;x<=val;x++)
            {
                lst.Add(x);
            }
            lst.RemoveAll(x => (x % 2 == 0));
            for (int y=0;y<lst.Count;y++)
            {
                int z = 1;
                while(true)
                {
                    Double quadrado = Math.Pow(Double.Parse(lst[y].ToString()),Double.Parse(z.ToString()));
                    if (quadrado < lst.Count)
                    {
                        lst.RemoveAt(int.Parse(quadrado.ToString())-1);
                        z++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("IsSortudo: " + lst.Contains(val));
            return lst.Contains(val);
        }
       
        /// <summary>
        /// Retorna a mensagem conforme o resultado das funções
        /// </summary>
        /// <param name="val"></param>
        /// <returns>Mensagem</returns>
        private static string FelizESortudo(int val)
        {       
            StringBuilder msg = new StringBuilder();
            msg.Append("Número ");

            if (IsSortudo(val))
            {
                msg.Append("Sortudo e ");
            }
            else
            {
                msg.Append("Não-Sortudo e ");
            }

            if (IsFeliz(val))
            {
                msg.Append("Feliz.");
            }
            else
            {
                msg.Append("Não-Feliz.");
            }
            return msg.ToString();
        }

        /// <summary>
        /// Valida entrada do usuário e retorna mensagem conforme o resultado
        /// </summary>
        /// <param name="val"></param>
        /// <returns>Mensagem para o usuário</returns>
        public static string ValidarEntrada(string val)
        {
            if (!int.TryParse(val, out int x))
            {
                return "Número inválido!";
            }
            if (int.Parse(val) <= 0)
            {
                return "Informe um número maior que zero!";
            }
            return FelizESortudo(int.Parse(val));
        }
    }
}
