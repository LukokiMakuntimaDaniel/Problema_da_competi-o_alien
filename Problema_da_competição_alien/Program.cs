using System;

namespace Problema_da_competição_alien
{
    class Program
    {
        public static int alien(int n, string s)
        {
            s = s + " ";
            int conta = 0;
            string soma = "";
            for(int cont=0; cont<s.Length; cont++)
            {
                char a =Convert.ToChar(s.Substring(cont, 1));
                if ( Convert.ToInt32(a)>=97 && Convert.ToInt32(a) <= 122)
                {
                    soma += s.Substring(cont, 1);
                }
                else
                {
                    if (soma.Length==n)
                    {
                        conta++;
                    }
                    soma = "";
                }

            }
            return conta;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            Console.WriteLine(alien(n,s));
        }
    }
}
