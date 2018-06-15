namespace ProgControle.Dados
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public class DBControle : DbContext
    {
        public DBControle()
            : base("name=DBControle")
        {
            Database.SetInitializer<DbContext>(new CreateDatabaseIfNotExists<DbContext>());
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    throw new UnintentionalCodeFirstException();
        //}

        public DbSet<OS> OS { get; set; }
        public DbSet<Ponto> Ponto { get; set; }
    }
}
