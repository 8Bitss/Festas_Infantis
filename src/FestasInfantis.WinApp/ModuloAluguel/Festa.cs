
namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Festa
    {
        public int Id { get; set; }
        public Endereco EnderecoSelecionado { get; set; }
        public DateTime Data { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraTermino { get; set; }

        public Festa(Endereco endereco, DateTime data, DateTime horaInicio, DateTime horaTermino)
        {
            EnderecoSelecionado = endereco;
            Data = data;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
        }

        public class Endereco
        {
            string Cidade { get; set; }
            string Rua { get; set; }
            string Bairro { get; set; }
            string Estado { get; set; }
            string Numero { get; set; }

            public Endereco(string cidade, string rua, string estado, string bairro, string numero)
            {
                Cidade = cidade;
                Rua = rua;
                Estado = estado;
                Bairro = bairro;
                Numero = numero;
            }
        }
    }
}
