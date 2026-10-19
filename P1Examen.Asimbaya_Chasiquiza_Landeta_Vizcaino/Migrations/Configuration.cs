namespace P1Examen.Asimbaya_Chasiquiza_Landeta_Vizcaino.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ExamenP1.Asimbaya_Chasiquiza_Landeta_Vizcaino.Models.ZodiacoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ExamenP1.Asimbaya_Chasiquiza_Landeta_Vizcaino.Models.ZodiacoDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
