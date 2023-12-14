using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_de_drones.Core
{
    /// <summary>
    /// drone de l'application
    /// </summary>
    public class Drone
    {

        #region Properties

        public string Matricule { get; set; } = String.Empty;

        public DateTime CreationDate { get; set; }

        // public HealthStatus HealthStatus { get; set; } = HealthStatus.Ok;

        public HealthStatus HealthStatus { get; set; } = HealthStatus.Ok;

        #endregion

        #region Constructors

        public Drone()
        {
            
        }

        #endregion

    }
}
