

namespace suivi_de_drones.Core.Interfaces.Repositories
{
    /// <summary>
    /// contract pour tout repository gérant des drones
    /// </summary>
    public interface IDroneRepository
    {
        List<Drone> GetAll();
    }
}
