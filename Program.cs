using System;
using System.Collections.Generic;
using System.Linq;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com conjuntos";

            //List<string> aulas = new List<string>
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            List<string> aulas = new List<string>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            //Console.WriteLine("A primeira aula é: " + aulas.First());
            //Console.WriteLine("A última aula é: " + aulas.Last());

            aulas[0] = "Trabalhando com Listas";
            Imprimir(aulas);

            Console.WriteLine("A primeira aula 'Trabalhando' é: " + aulas.First(aula => aula.Contains("Trabalhando")));

            Console.WriteLine("A úlima aula 'Trabalhando' é: " + aulas.Last(aula => aula.Contains("Trabalhando")));

            Console.WriteLine("A primeira aula 'Conclusão' é: " + aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));

            aulas.Reverse();

            Imprimir(aulas);


            aulas.RemoveAt(aulas.Count - 1);

            aulas.Add("Conclusão");
            
            aulas.Sort();
            Imprimir(aulas);

            List<string> copia = aulas.GetRange(aulas.Count() - 2, 2); 
            Imprimir(copia);

            List<string> clone = new List<string>(aulas);
            Imprimir(copia);

            clone.RemoveRange(clone.Count - 2, 2);
            Imprimir(clone);

            #region Aula Arrays
            //string[] aulas = new string[] 
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            //string[] aulas = new string[3];
            //aulas[0] = aulaIntro;
            //aulas[1] = aulaModelando;
            //aulas[2] = aulaSets;

            //Imprimir(aulas);

            //aulaIntro = "TrabalhandoComArrays";

            //aulas[0] = "Gushtaaaavo";

            //Console.WriteLine(aulas[0]);
            //Console.WriteLine(aulas[aulas.Length - 1]);

            //Console.WriteLine("Aula modelando está no indice " + Array.IndexOf(aulas, aulaModelando));
            //Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));

            //Array.Reverse(aulas);

            //Array.Resize(ref aulas, 2);
            //Imprimir(aulas);

            //Array.Sort(aulas);
            //Imprimir(aulas);

            //string[] copia = new string[2];

            //Array.Copy(aulas, 0, copia, 0, 2);
            //Imprimir(copia);

            //string[] clone = aulas.Clone() as string[];
            //Imprimir(clone);

            //Array.Clear(clone, 1, 2);
            //Imprimir(clone);

            #endregion
        }

        public static void Imprimir(List<string> aulas)
        {
            Console.Write("\n");
            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });

            //for (int i = 0; i < aulas.Length; i++)
            //{
            //    Console.WriteLine(aulas[i]);
            //}
        }
    }
}
