namespace EasyTalents.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    internal sealed class Configuration : DbMigrationsConfiguration<EasyTalents.Models.talentsEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EasyTalents.Models.talentsEntities context)
        {

            context.availabilities.AddOrUpdate(x => x.Id,
                new availability { desc = "Up to 4 hours per day / Até 4 horas por dia" },
                new availability { desc = "4 to 6 hours per day / De 4 á 6 horas por dia" },
                new availability { desc = "6 to 8 hours per day /De 6 á 8 horas por dia" },
                new availability { desc = "Up to 8 hours a day (are you sure?) / Acima de 8 horas por dia (tem certeza?)" },
                new availability { desc = "Only weekends / Apenas finais de semana" });

            context.besttimes.AddOrUpdate(x => x.Id,
                new besttime { desc = "Morning (from 08:00 to 12:00) / Manhã (de 08:00 ás 12:00)" },
                new besttime { desc = "Afternoon (from 1:00 p.m. to 6:00 p.m.) / Tarde (de 13:00 ás 18:00)" },
                new besttime { desc = "Night (7:00 p.m. to 10:00 p.m.) /Noite (de 19:00 as 22:00)" },
                new besttime { desc = "Dawn (from 10 p.m. onwards) / Madrugada (de 22:00 em diante)" },
                new besttime { desc = "Business (from 08:00 a.m. to 06:00 p.m.) / Comercial (de 08:00 as 18:00)" });

        }
    }
}
