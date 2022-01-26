using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DictatorsInformationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DictatorController : Controller
    {
        private List<DictatorModel> dictators = new List<DictatorModel>();

        [HttpGet]
        public ActionResult<IEnumerable<DictatorModel>> GetDictators()
        {
            dictators.Add(new DictatorModel("Steffen", "yy", "1985-08-03" , "10-10-2090", "this is a test"));
            return Ok( dictators);
        }

        [HttpPost]
        public ActionResult<DictatorModel> PostDictator(DictatorModel dictator)
        {
            var model = dictator;

            dictators.Add(dictator);
            return Ok( dictator);
        }
    }
}
