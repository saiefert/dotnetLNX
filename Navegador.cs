using System;
using System.Collections.Generic;
using System.Linq;

namespace Study
{
    internal class Navegador
    {
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();
        private string atual = "vazia";

        public Navegador()
        {
            Console.WriteLine("Página Atual: " + atual);
        }

        internal void NavegarPara(string url)
        {
            historicoAnterior.Push(atual);
            atual = url;
            Console.WriteLine(atual);
        }

        internal void Anterior()
        {
            if (historicoAnterior.Any())
            {
                atual = historicoAnterior.Pop();
                historicoProximo.Push(atual);
                Console.WriteLine(atual);
            }
        }

        internal void Proximo()
        {
            if (historicoProximo.Any())
            {
                historicoAnterior.Push(atual);
                atual = historicoProximo.Pop();
                Console.WriteLine(atual);
            }
        }
    }
}

