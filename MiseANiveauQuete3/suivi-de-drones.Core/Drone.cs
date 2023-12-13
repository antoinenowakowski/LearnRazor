using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_de_drones.Core
{
    public class Drone
    {

        /// <summary>
        /// Drone de l'application
        /// </summary>
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
