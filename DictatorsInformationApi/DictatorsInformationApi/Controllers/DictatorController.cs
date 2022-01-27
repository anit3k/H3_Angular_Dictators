using Amazon.CloudFront.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DictatorsInformationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DictatorController : Controller
    {
        private List<DictatorModel> dictators = new List<DictatorModel>();

        public DictatorController()
        {
            dictators.Add(new DictatorModel("Steffen", "halberg", "1985-08-03" , "10-10-2090", "this is a test"));
            dictators.Add(new DictatorModel("Mads", "Tinko", "1985-08-03", "10-10-2090", "this is a test"));
        }

        [HttpGet]
        public ActionResult<IEnumerable<DictatorModel>> GetDictators()
        {
            return Ok(dictators);
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
