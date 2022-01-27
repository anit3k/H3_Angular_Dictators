using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DictatorsInformationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DictatorController : Controller
    {
        private static List<DictatorModel> dictators = new List<DictatorModel>();

        public DictatorController()
        {
            if (dictators.Count == 0)
            {
                // Source of information https://www.borgenmagazine.com/10-worst-dictators-time/
                dictators.Add(new DictatorModel("Nicholas", "II", "1868", "1918", "Nicholas II was the last, and arguably the bloodiest, star of Russia. Nicholas’s most infamous act is now referred to as “Bloody Sunday.” When peaceful protesters led a march through St.Petersburg for better working conditions and the establishment of popular assemblies, Nicholas II had his troops open fire on the crowd, killing over a thousand innocent demonstrators."));
                dictators.Add(new DictatorModel("Bashar ", "al-Assad", "1965", "", "Following in the footsteps of his father, the current president of Syria is known to use chemical weapons against civilians, killing innocent women and children in the process. In addition to his deeds on the ground, al-Assaad has placed bans on social media sites such as YouTube and Facebook, and passed a law demanding that anything said on online forums be made public and under scrutiny of the Syrian armed forces."));
                dictators.Add(new DictatorModel("Leopold", "II of Belgium", "1835", "1909", "As King of Belgium, Leopold II became notorious for exploiting labor from the Congo, which he claimed in the name of Belgium. The Congolese people were forced to work in mines and collect ivory to export. To keep the Congolese workers in line, Leopold authorized the use of beatings and violence. When beatings were not enough, Leopold created a private army, the Force Publique, which burned villages of rebels and killed as many disobedient citizens as possible in the process."));
                dictators.Add(new DictatorModel("Robert", "Mugabe", "1924", "", "Robert Mugabe is one of the world’s worst dictators because he is known for having his presidential running mate’s supporters brutally murdered in order to secure the position as feared, long-term president of Zimbabwe. In addition to the utilization of violence against those who disagree with his beliefs, Mugabe and his administrative staff commonly give themselves pay raises, despite their country’s economic problems."));
                dictators.Add(new DictatorModel("Joseph", "Stalin", "1878", "1953", "One of the most well-known dictators, Joseph Stalin, ruled the Soviet Union using tactics of terror and pain. Under Stalin’s rule, millions of Russian civilians died from forced labor, starved from famine and were executed by Stalin’s military."));
                dictators.Add(new DictatorModel("Saddam", "Hussein", "1937", "2006", "As president of Iraq, Hussein did many things to improve Iraq’s education system, health care and more. However, Hussein’s most notable acts were the armies he built, the most well-known being the People’s Army. These armies viciously tortured, raped and killed while carrying out Hussein’s orders."));
                dictators.Add(new DictatorModel("Mao", "Zedong", "1893", "1976", "Over the course of four years, Mao Zedong’s “Great Leap Forward” campaign killed 45 million, making him the most deadly dictator in history thus far. Zedong also established China’s cultural revolution which resulted in the destruction of valuable Chinese artifacts. The cultural revolution led to schools being closed and children being sent to labor camps to be “re-educated” in ways that pleased Zedong."));
                dictators.Add(new DictatorModel("Adolf", "Hitler", "1889", "1945", "Empirically the most well-known of the world’s worst dictators, Hitler started his own political party and initiated the Second World War, all in a span of 10 years. Hitler’s most gruesome act was orchestrating the Holocaust, which brought death to an estimated 14 million innocent people."));
                dictators.Add(new DictatorModel("Idi", "Amin", "1925", "2003", "In addition to being Uganda’s president, Idi Amim is known as the “Butcher of Uganda.” During his presidency, Amim was responsible for roughly 300,000 deaths in Uganda. To keep his citizens in check, Amim created a personal army ironically named the “Public Safety Unit and the State Research Bureau.” Amim’s army was responsible for torturing and killing hundreds of Ugandan people for money, houses and women."));
                dictators.Add(new DictatorModel("Fidel", "Castro", "1926", "", "During his time as President of Cuba, Fidel Castro was subject to negative lime-light thanks to the Bay of Pigs invasion, a famous attempt made by the U.S. CIA to remove Castro from office, as well as the prominent Cuban missile crisis. To keep his command over Cuba, Castro frequently removed his opposition through the use of executions, imprisonments and forced emigration."));
            }
        }

        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<DictatorModel>> GetDictators()
        {
            return Ok(dictators);
        }

        [HttpPost]
        [Route("")]
        public ActionResult<DictatorModel> PostDictator(DictatorModel dictator)
        {
            dictators.Add(dictator);
            return Ok(dictator);
        }

        [Route("{id}")]
        [HttpDelete]
        public ActionResult<DictatorModel> DelelteDictator(string id)
        {
            dictators.Remove(dictators.Find(x => x.Id == id));
            return Ok("Delete OK");
        }
    }
}
