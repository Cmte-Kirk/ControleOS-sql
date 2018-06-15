namespace ProgControle.Dados
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public class OS
    {
        [Key]
        public int IDOS { get; set; }
        public string OS1 { get; set; }
        public string DESCRICAO { get; set; }
        public Nullable<System.DateTime> DTINICIO { get; set; }
        public Nullable<System.DateTime> DTFIM { get; set; }
        public Nullable<System.TimeSpan> TEMPOGASTO { get; set; }

    }
}