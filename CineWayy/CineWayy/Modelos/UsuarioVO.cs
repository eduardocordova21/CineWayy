using CineWayy.Enums;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineWayy.Modelos
{
    [Table("Usuario")]
    public class UsuarioVO
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public TiposDeUsuarios TipoDeUsuario { get; set; }
    }
}
