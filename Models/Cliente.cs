using System.Collections.Generic;
using Projeto0307.Models;

public class Cliente
{
    public string Nome { get; set; }
    public string DataNascimento { get; set; }
    public string CPF { get; set; }
    public string Sexo { get; set; }
    public List<Endereco> Endereco { get; set; } = new List<Endereco>();
    public string Celular { get; set; }
    public string TelefoneRes { get; set; }
    public string TelefoneCom { get; set; }
    public string Alternativo { get; set; }
    public string Email { get; set; }
    public string Status { get; set; }
    public Cliente(string nome, string dataNascimento, string cpf, List<Endereco> endereco, string celular, string telefoneRes, string telefoneCom, string email, string status, string sexo, string alternativo = "")
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        CPF = cpf;
        Endereco = endereco;
        Celular = celular;
        TelefoneRes = telefoneRes;
        TelefoneCom = telefoneCom;
        Email = email;
        Status = status;
        Sexo = sexo;
        Alternativo = alternativo;
    }
}
