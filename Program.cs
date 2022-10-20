using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> filaInteiros;
            filaInteiros = new Queue<int>();

            filaInteiros.Enqueue(15);
            mostraFila(filaInteiros);
            filaInteiros.Enqueue(25);
            filaInteiros.Enqueue(21);
            filaInteiros.Enqueue(22);
            filaInteiros.Enqueue(23);
            filaInteiros.Enqueue(20);
            mostraFila(filaInteiros);

            Console.WriteLine("Primeiro da fila: {0}", filaInteiros.First());
            Console.WriteLine("Último da fila: {0}", filaInteiros.Last());
            mostraFila(filaInteiros);

            Console.WriteLine("Desenfileirado: {0}", filaInteiros.Dequeue());
            mostraFila(filaInteiros);

            Console.WriteLine("Elemento na posição 1: {0}", filaInteiros.ElementAt(1));

        }

        static void mostraFila(Queue<int> fila)
        {
            int posicao = 0;
            Console.WriteLine("Qtde de elementos: {0}", fila.Count);
            foreach (int i in fila)
            {
                Console.WriteLine("Elemento posição {0}: {1}", posicao++, i);
            }
            Console.WriteLine("----------------");

        }
    }
}
