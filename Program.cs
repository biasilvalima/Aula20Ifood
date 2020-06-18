using System;

namespace Aula20Ifood
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurante BK = new Restaurante();
            BK.NomeRestaurante = "BK";
            BK.Endereco = "Osasco-sp";
            BK.MostrarDados();

            System.Console.WriteLine();

            Cliente N1 = new Cliente();
            N1.Nome = "Beatriz";
            N1.Endereco = "Carapicuina-sp";
            N1.PontodeReferencia = "Banco Bradesco";
            N1.MostrarDados();

            System.Console.WriteLine();

            Pedido especial = new Pedido("Brothers Hamburgueria", "Cartão de crédito", "Lanche especial á moda da casa", "Coca-cola", "Molho especial");
            System.Console.WriteLine(especial.Restaurante);
            System.Console.WriteLine(especial.FormadePagamento);
            System.Console.WriteLine(especial.NomeLanche);
            System.Console.WriteLine(especial.Bebida);
            System.Console.WriteLine(especial.Acompanhamento);

            System.Console.WriteLine("Agradecemos a preferência!");

            
            

        
        }
    }
}
