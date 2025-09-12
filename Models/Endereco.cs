namespace Projeto0307.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }

        public Endereco(int id, string cep, string uf, string cidade, string bairro, string numero, string logradouro, string complemento)
        {
            Id = id;
            CEP = cep;
            UF = uf;
            Cidade = cidade;
            Bairro = bairro;
            Numero = numero;
            Logradouro = logradouro;
            Complemento = complemento;
        }

        // Construtor alternativo se quiser permitir construir só com cidade/bairro
        public Endereco(string cidade, string bairro, string numero, string logradouro, string complemento)
        {
            Cidade = cidade;
            Bairro = bairro;
            Numero = numero;
            Logradouro = logradouro;
            Complemento = complemento;
        }
    }
}
