using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using suivi_de_drones.Core;
using suivi_de_drones.Core.Interfaces.Infrastructures;
using suivi_de_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Infrastructure.Databases;
using suivi_des_drones.Core.Infrastructure.DataLayers;

namespace suivi_de_drones.Web.UI.Pages
{
    public class IndexModel : PageModel
    {

        #region Fileds

        private readonly ILogger<IndexModel> _logger;
        private readonly IDroneRepository repository;

        #endregion


        #region Constructors

        public IndexModel(ILogger<IndexModel> logger, IDroneRepository repository, IConfiguration configuration)
        {
            _logger = logger;
            this.repository = repository;
        }

        #endregion


        #region Public methods

        /* Première méthode
        public void OnGet()
        {
            // Drone drone = new ();
            // List<>
        }*/

        // deuxième méthode
        public IActionResult OnGet()
        {
            IActionResult result = this.Page();

            //if(true)
            //{
            //    result  = this.BadRequest();
            //}

            this.SetListOfDrones();
            this.SetListStatus();

            return result;
        }

        /* Troisième méthode
        public async Task<IActionResult> OnGetAsync()
        {
            return this.Page();
        }*/

        #endregion


        #region Internal Methods

        private void SetListOfDrones()
        {
            //this.Drones.Add(new Drone() { Matricule = "54XXD0", CreationDate = DateTime.Now, HealthStatus = HealthStatus.Repair });
            //this.Drones.Add(new Drone() { Matricule = "FR2436", CreationDate = DateTime.Now.AddDays(-150), HealthStatus = HealthStatus.Broken });
            //this.Drones.Add(new Drone() { Matricule = "FR1288", CreationDate = DateTime.Now.AddHours(-24), HealthStatus = HealthStatus.Ok });

            // var dataLayer = new SqlServerDroneDataLayer();

            this.Drones = this.repository.GetAll();
        }

        private void SetListStatus()
        {
            this.StatusList.Add(HealthStatus.Ok);
            this.StatusList.Add(HealthStatus.Repair);
            this.StatusList.Add(HealthStatus.Broken);
        }

        #endregion


        #region Properties

        public List<Drone> Drones { get; set; } = new List<Drone>();
        public List<HealthStatus> StatusList { get; set; } = new();

        #endregion
    }
}
