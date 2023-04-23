using Associacao_e_Composicao_Exercicios.Entities;
namespace Associacao_e_Composicao_Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PenteMemoria penteMemoria = new PenteMemoria(16);
            Fonte fonte = new Fonte(5, 0.5, "Corsair");
            Processador processador = new Processador("Intel Core I9 13400k", 6.0, 32);
            PlacaMae placaMae = new PlacaMae("Aorus ELITE", "Placa mae cara");
            placaMae.associarpentememoria(penteMemoria);
            placaMae.associarfonte(fonte);
            placaMae.associarprocessador(processador);
            Computador computador = new Computador("G15", "Dell", placaMae);
            Console.WriteLine(computador);
        }
    }
}