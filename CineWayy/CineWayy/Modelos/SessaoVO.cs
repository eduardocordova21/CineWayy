using CineWayy.Enums;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineWayy.Modelos
{
    [Table("Sessao")]
    public class SessaoVO
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public DateTime Horario { get; set; }

        public double ValorDoIngresso { get; set; }

        public TiposDeAnimacao TipoDeAnimacao { get; set; }

        public TiposDeAudios TipoDeAudio { get; set; }

        public int FilmeID { get; set; }

        public int SalaID { get; set; }
    }
}
