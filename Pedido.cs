namespace Aula20Ifood
{
    public class Pedido
    {
        public string Cliente { get; set; }
        public string Restaurante { get; set; }
        public string FormadePagamento { get; set; }
        public bool PedidoPago { get; set; }
        
        public string NomeLanche { get; set; }
        public string Bebida { get; set; }
        public string Acompanhamento { get; set; }

        public Pedido(string _nomeLanche, string _bebida)
        {
            this.NomeLanche = _nomeLanche;
            this.Bebida = _bebida;
        }

                public Pedido(string _restaurante, string _formadePagamento, string _nomeLanche, string _bebida, string _acompanhamento)
        {
            this.Restaurante = _restaurante;
            this.FormadePagamento = _formadePagamento;
            this.NomeLanche = _nomeLanche;
            this.Bebida = _bebida;
            this.Acompanhamento = _acompanhamento;
        }
    }
}