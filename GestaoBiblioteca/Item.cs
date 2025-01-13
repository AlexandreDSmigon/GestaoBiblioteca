using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoBiblioteca
{
    /// <summary>
    /// Um item disponível na biblioteca.
    /// </summary>
    internal class Item
    {
        /// <summary>
        /// O tipo do item.
        /// </summary>
        public TipoItem Tipo { get; set; } = TipoItem.Nulo;

        /// <summary>
        /// O identificador do item.
        /// </summary>
        public int ID { get; set; } = -1;

        /// <summary>
        /// O título do item.
        /// </summary>
        public string Titulo { get; set; } = String.Empty;

        /// <summary>
        /// O autor do item.
        /// </summary>
        public string Autor { get; set; } = String.Empty;

        /// <summary>
        /// O ano de criação ou edição do item.
        /// </summary>
        public int Ano { get; set; } = 0;

        /// <summary>
        /// Quantidade do item em stock.
        /// </summary>
        public int Quantidade { get; set; } = 0;

        public Item()
        { }

        public Item(TipoItem tipo, string titulo, string autor, int ano, int quantidade)
        {
            Tipo = tipo;
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
            Quantidade = quantidade;
        }

    }
}
