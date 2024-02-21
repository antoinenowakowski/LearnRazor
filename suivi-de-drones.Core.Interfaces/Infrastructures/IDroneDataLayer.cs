using suivi_de_drones.Core;

namespace suivi_de_drones.Core.Interfaces.Infrastructures
{
    /// <summary>
    /// Isole l'accès à la base de données
    /// </summary>
    public interface IDroneDataLayer
    {
        /// <summary>
        /// Retourne la liste complète
        /// </summary>
        /// <returns></returns>
        List<Drone> GetList();
    }
}
