using System;
using System.Collections.Generic;
using System.Linq;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 

            // var aulaIntro = new Aula("Introdução às Coleções", 20);
            // var aulaModelando = new Aula("Modelando a Classe Aula", 18);
            // var aulaSets = new Aula("Trabalhando com conjuntos", 10);

            // List<Aula> aulas = new List<Aula>();
            // aulas.Add(aulaIntro);
            // aulas.Add(aulaModelando);
            // aulas.Add(aulaSets);

            // aulas.Sort();

            // Imprimir(aulas);

            Curso csharpColecoes = new Curso("C#", "Josmar");
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
            // ISet<string> alunos = new HashSet<string>();

            // alunos.Add("Vanessa Tonini");
            // alunos.Add("Ana Losnak");
            // alunos.Add("Rafael");

            // Console.WriteLine(alunos);
            // Console.WriteLine(string.Join(",", alunos));

            // alunos.Add("Rafae");
            // Console.WriteLine(string.Join(",", alunos));

            #endregion

            // Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            // Aluno a2 = new Aluno("Ana Losnak", 5617);
            // Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            // //Precisamos Matricular os alunos no curso, criando um método
            // csharpColecoes.Matricula(a1);
            // csharpColecoes.Matricula(a2);
            // csharpColecoes.Matricula(a3);

            // //Imprimindo os alunos matriculados
            // Console.WriteLine("Imprimindo os alunos matriculados");
            // foreach (var aluno in csharpColecoes.Alunos)
            // {
            //     Console.WriteLine(aluno);
            // }

            // //Imprimir: "O aluno a1 está matriculado?"
            // Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado?");
            // //Criar um método EstaMatriculado
            // Console.WriteLine(csharpColecoes.EstaMatriculado(a1));

            // Console.Clear();
            // Aluno aluno5617 = csharpColecoes.BuscaMatriculado(5617);

            // Console.WriteLine("Aluno 5617: "+ aluno5617);

            Console.WriteLine(UnixTimestampToDateTime(1391223600000));

            //Double timestamp = 1498122000;           

        }

        public static DateTime UnixTimestampToDateTime(double unixTime)
        {
            var localDateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(unixTime)
        .DateTime.ToLocalTime();
            return localDateTimeOffset;
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
