using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineWayy.Modelos
{
    [Table("Sala")]
    public class SalaVO
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Nome { get; set; }

        public int QuantidadeDeAssentos { get; set; }
    }
}
