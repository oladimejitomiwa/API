
using API_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Project.Controllers
{
    [Route("api/TYD")]
    [ApiController]
    public class TYDController: ControllerBase
    {
        [HttpGet]
        public IEnumerable<TYD> GetTYDs()
        {
            return new List<TYD>
                {
                    new TYD {TYDRegionId = 1, TYDRegionName= "United Staets" } ,
                    new TYD {TYDRegionId = 2, TYDRegionName= "Nigeria" }

                };

        }






    }
    
   
}
