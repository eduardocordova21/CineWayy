using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CineWayy.Modelos
{
    [Table("Filme")]
    public class FilmeVO
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Imagem { get; set; }

        public string Titulo { get; set; }

        public string  Descricao { get; set; }

        public string Duracao { get; set; }
    }
}
