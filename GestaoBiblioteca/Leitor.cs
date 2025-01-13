using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GestaoBiblioteca
{
    /// <summary>
    /// Representa um leitor da biblioteca, ou seja, uma pessoa que frequenta e utiliza os recursos da biblioteca.
    /// </summary>
    internal class Leitor : Pessoa
    {
        /// <summary>
        /// O número do cartão da biblioteca.
        /// </summary>
        public string NumeroCartao { get; set; } = String.Empty;

        public string CartaoCidadao { get; set; } = String.Empty;

        public string Nif { get; set; } = String.Empty;

        public DateTime DataNascimento { get; set; }

        public string Morada { get; set; } = String.Empty;

        public string CodigoPostal { get; set; } = String.Empty;

        public string Localidade { get; set; } = String.Empty;

        public Leitor() : base()
        { }

        public Leitor(bool ativo, int id, string nome, string email, 
                      string telefone, string numeroCartao,
                      string cartaoCidadao, string nif,
                      DateTime dataNascimento, string morada,
                      string codigoPostal, string localidade)
            : base(ativo, id, "", "", nome, email, telefone)
        {
            NumeroCartao = numeroCartao;
            CartaoCidadao = cartaoCidadao;
            Nif = nif;
            DataNascimento = dataNascimento;
            Morada = morada;
            CodigoPostal = codigoPostal;
            Localidade = localidade;
        }
    }
}
