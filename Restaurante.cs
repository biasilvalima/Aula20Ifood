namespace Aula20Ifood
{
    public class Restaurante
    {
        public string NomeRestaurante { get; set; }
        public string Endereco { get; set; }


        public void MostrarDados()
        {
            System.Console.WriteLine($"O nome do restaurante é {NomeRestaurante} e o endereço desse  é {Endereco}");      
        }

        
    }
}