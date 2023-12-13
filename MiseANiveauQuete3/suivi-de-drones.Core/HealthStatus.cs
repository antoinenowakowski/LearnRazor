using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_de_drones.Core
{
    //public enum HealthStatus
    //{
    //    Ok = 0, 
    //    Broken = -1,
    //    Repair = -2
    //}

    public class HealthStatus
    {
        public static HealthStatus Ok = new HealthStatus() { Id = 0, Label = "Ok" };
        public static HealthStatus Broken = new HealthStatus() { Id = -1, Label = "Broken" };
        public static HealthStatus Repair = new HealthStatus() { Id = -2, Label = "Repair" };

        public int Id { get; set; } = 0;
        public string Label { get; set; } = default!;
    }
}
