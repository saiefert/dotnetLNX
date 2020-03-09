using System;
using System.Collections.Generic;
using System.Linq;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            // var aulaIntro = new Aula("Introdução às Coleções", 20);
            // var aulaModelando = new Aula("Modelando a Classe Aula", 18);
            // var aulaSets = new Aula("Trabalhando com conjuntos", 10);

            // List<Aula> aulas = new List<Aula>();
            // aulas.Add(aulaIntro);
            // aulas.Add(aulaModelando);
            // aulas.Add(aulaSets);

            // aulas.Sort();

            // Imprimir(aulas);

            // Curso csharpColecoes = new Curso("C#", "Josmar");
            // csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 20));
            // Imprimir(csharpColecoes.AulasReadyOnly);

            // //Adicionar 2 aulas
            // csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            // csharpColecoes.Adiciona(new Aula("Modelando com coleções", 19));

            // Imprimir(csharpColecoes.AulasReadyOnly);

            // //Ordenar a lista de aulas
            // //csharpColecoes.AulasReadyOnly.Sort();

            // //copiar a lista para outra lista
            // List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.AulasReadyOnly);

            // //ordenar a cópia
            // aulasCopiadas.Sort();

            // Imprimir(aulasCopiadas);

            // //totalizar o tempo do curso
            // Console.WriteLine(csharpColecoes.TempoTotal);
            // Console.WriteLine(csharpColecoes.ToString());

            //SETS = CONJUNTOS
            //1. não permite duplicidade
            //2. os elementos não são mantidos em ordem específica

            //declarando set de alunos
            ISet<string> alunos = new HashSet<string>();

            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael");

            Console.WriteLine(alunos);
            Console.WriteLine(string.Join(",", alunos));

            alunos.Add("Rafae");
            Console.WriteLine(string.Join(",", alunos));
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }

    class Aula : IComparable
    {
        string _aula;
        int _tempo;

        public Aula(string aula, int tempo)
        {
            _aula = aula;
            _tempo = tempo;
        }

        public string Aulas { get => _aula; set => _aula = value; }
        public int Tempo { get => _tempo; set => _tempo = value; }

        public int CompareTo(object obj)
        {
            var objeto = obj as Aula;

            return Aulas.CompareTo(objeto.Aulas);
        }

        public override string ToString()
        {
            return $"[Aulas: {Aulas}, Horas: {Tempo}]";
        }
    }
}
