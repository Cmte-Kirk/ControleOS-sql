namespace ProgControle.Dados
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    [Table("Ponto")]
    public class Ponto
    {
        [Key]
        public int IdPonto { get; set; }
        public DateTime Data { get; set; }
        public Nullable<System.TimeSpan> Entrada { get; set; }
        public Nullable<System.TimeSpan> Saida { get; set; }

        public Ponto()
        {

        }
        public Ponto(DateTime Data)
        {
            this.Data = Data;
        }
    }
}
