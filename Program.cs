using System;
using System.Collections.Generic;
using System.Linq;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            var aulaIntro = new Aula("Introdução às Coleções", 20);
            var aulaModelando = new Aula("Modelando a Classe Aula", 18);
            var aulaSets = new Aula("Trabalhando com conjuntos", 10);

            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            Imprimir(aulas);
        }

        private static void Imprimir(List<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }

    class Aula
    {
        string _aula;
        int _hora;

        public Aula(string aula, int hora)
        {
            _aula = aula;
            _hora = hora;
        }

        public string Aulas { get => _aula; set => _aula = value; }
        public int Hora { get => _hora; set => _hora = value; }
    }
}
