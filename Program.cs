using System;
using System.Collections.Generic;
using System.Linq;

namespace Study
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C#", "Josmar");

            #region Listas

            // var aulaIntro = new Aula("Introdução às Coleções", 20);
            // var aulaModelando = new Aula("Modelando a Classe Aula", 18);
            // var aulaSets = new Aula("Trabalhando com conjuntos", 10);

            // List<Aula> aulas = new List<Aula>();
            // aulas.Add(aulaIntro);
            // aulas.Add(aulaModelando);
            // aulas.Add(aulaSets);

            // aulas.Sort();

            // Imprimir(aulas);

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

            #endregion

            #region Sets (Coleções)
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

            #endregion

            #region Dicionarios (Coleções)
            // //Imprimir: "O aluno a1 está matriculado?"
            // Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado?");
            // //Criar um método EstaMatriculado
            // Console.WriteLine(csharpColecoes.EstaMatriculado(a1));

            // Console.Clear();
            // Aluno aluno5617 = csharpColecoes.BuscaMatriculado(5617);

            // Console.WriteLine("Aluno 5617: "+ aluno5617);

            #endregion

            #region Linked List
            // var dias = new LinkedList<string>();

            // var d4 = dias.AddFirst("Quarta");
            // var d2 = dias.AddBefore(d4, "Segunda");
            // var d6 = dias.AddAfter(d4, "Sexta");
            // var d7 = dias.AddAfter(d6, "Sábado");
            // var d5 = dias.AddBefore(d6, "Quinta");
            // var d1 = dias.AddBefore(d2, "Domingo");
            // var d3 = dias.AddBefore(d4, "Terça");

            // foreach (var item in dias)
            // {
            //     Console.WriteLine(item);
            // }

            // //Linked list não dá suporte ao acesso por índice: dias[0]
            // //Por isso podemos fazer um laço foreach mas não um for!

            // dias.Remove(d5);

            #endregion

            #region  Stack (Pilha)
            // var navegador = new Navegador();
            // navegador.NavegarPara("google.com");
            // navegador.NavegarPara("caelum.com.br");
            // navegador.NavegarPara("alura.com.br");

            // navegador.Anterior();
            // navegador.Anterior();
            // navegador.Anterior();

            // navegador.Proximo();

            #endregion

            Enfileirar("van");
            Enfileirar("kombi");
            Enfileirar("guincho");
            Enfileirar("pickup");

            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                string veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da fila: {veiculo}");
                ImprimirFila();
            }

            if (pedagio.Peek() == "guincho")
            {
                Console.WriteLine("Guincho está fazendo pagamento");
            }
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}");
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("FILA: ");

            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
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
