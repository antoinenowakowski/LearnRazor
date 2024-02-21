using suivi_de_drones.Core.Interfaces.Infrastructures;
using suivi_de_drones.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_de_drones.Core.Repositories.Repositories
{
    /// <summary>
    /// Repository qui gère les drones, la création, la lecture...
    /// </summary>
    public class DroneRepository : IDroneRepository
    {

        #region Fields

        private readonly IDroneDataLayer dataLayer;

        #endregion

        #region Constructor

        public DroneRepository(IDroneDataLayer dataLayer)
        {
            this.dataLayer = dataLayer;
        }

        #endregion


        #region Public Methods
        public List<Drone> GetAll()
        {
            //// return new List<Drone>();
            //return new ()
            //{
            //    new Drone(),
            //    new ()
            //};
            //// commme un tableau 
            ///

            List<Drone> list = this.dataLayer.GetList();
            
            if (list.Count == 0)
            {
                throw new ArgumentNullException();
            }

            return list;

        }
        #endregion

    }
}