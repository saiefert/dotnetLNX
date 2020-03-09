using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Study
{
    class Curso
    {
        private IList<Aula> aulas;
        public IList<Aula> AulasReadyOnly
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        private string instrutor;
        private string nome;

        public Curso(string instrutor, string nome)
        {
            this.instrutor = instrutor;
            this.nome = nome;
            this.aulas = new List<Aula>();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public int TempoTotal
        {
            get
            {
                // int total = 0;
                // foreach (var aula in aulas)
                // {
                //     total += aula.Tempo;
                // }

                return aulas.Sum(x => x.Tempo);
            }
        }

        public override string ToString()
        {
            return $"Curso: {Nome}, Tempo: {TempoTotal}, Aulas: {string.Join(",", aulas)}";
        }
    }
}