namespace Aula20Ifood
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string PontodeReferencia { get; set; }

        public void MostrarDados(){
            System.Console.WriteLine($"O nome do cliente é {Nome}, seu endereço é {Endereco} e o ponto de referencia é {PontodeReferencia}");
        }

        
    }
}