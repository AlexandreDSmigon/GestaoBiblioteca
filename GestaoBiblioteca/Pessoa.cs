using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoBiblioteca
{
    /// <summary>
    /// Representa uma pessoa (utilizador ou leitor).
    /// </summary>
    internal abstract class Pessoa
    {
        /// <summary>
        /// Indica se a conta da pessoa está ativa no sistema.
        /// </summary>
        public bool Ativo { get; set; } = false;

        /// <summary>
        /// O identificador da pessoa.
        /// </summary>
        public int ID { get; set; } = -1;

        /// <summary>
        /// O nome de utilizador para acesso ao sistema.
        /// </summary>
        public string Username { get; set; } = String.Empty;

        /// <summary>
        /// A password para acesso ao sistema.
        /// </summary>
        public string Password { get; set; } = String.Empty;

        /// <summary>
        /// O nome completo da pessoa.
        /// </summary>
        public string Nome { get; set; } = String.Empty;

        public string Email { get; set; } = String.Empty;

        /// <summary>
        /// Contacto telefónico.
        /// </summary>
        public string Telefone { get; set; } = String.Empty;

        public Pessoa()
        { }

        public Pessoa(bool ativo, int id, string username, string password, string nome, string email, string telefone)
        {
            Ativo = ativo;
            ID = id;
            Username = username;
            Password = password;
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }
    }
}
