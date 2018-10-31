using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/[controller]")]
    public class CitiesController : Controller
    {
        public JsonResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current);
        }
    }
}
