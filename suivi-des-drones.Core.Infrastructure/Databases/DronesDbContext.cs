using Microsoft.EntityFrameworkCore;
using suivi_de_drones.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Infrastructure.Databases
{
    public class DronesDbContext : DbContext
    {


        #region Constructors
        public DronesDbContext(DbContextOptions options) : base(options)
        {
        }

        public DronesDbContext()
        {
        }


        #endregion

        #region Properties
        // permet déclarer sur quelle liste on se connecte ( ici, la classe drone )
        public DbSet<Drone> Drones { get; set; }
        #endregion

    }
}
