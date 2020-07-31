namespace NexuscsCalenge.Infraestrutura.data.Migrations
{
    using NexuscsChallenge.Infraestrutura.data;
    using NexuscsChallenge.Infraestrutura.data.Context;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NexuscsChallenge.Infraestrutura.data.Context.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context context)
        {
           
        }
    }
}
