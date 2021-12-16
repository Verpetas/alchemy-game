using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Scraper
{
    public class Scraper
    {
        public static async Task HTMLGetter(string version, string location)
        {
            Dictionary<string, List<string>> combos = new Dictionary<string, List<string>>();

            Console.WriteLine("stratring getter with var " + version);

            string url;

            if(version == "Alchemy v1.0")
            {
                url = "https://doodlealchemy.gambledude.com/doodle-alchemy-all-combinations.html";
            }
            else
            {
                url = "https://ayumilove.net/doodle-" + version + "/";
            }

            HttpClient httpClient = new HttpClient();

            var html = await httpClient.GetStringAsync(url);

            if (version == "Alchemy v1.0")
                OldVer(html, location);
            else
                NewVer(html, location);
        }

        public static void OldVer(string html, string location)
        {
            Console.WriteLine("Executing Alchemy 1.0");

            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            var productItems = htmlDocument.DocumentNode.Descendants("td")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("combo-name")).ToList();

            var makeupItems = htmlDocument.DocumentNode.Descendants("td")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("allcombos")).ToList();

            Dictionary<string, List<String>> combos = new Dictionary<string, List<String>>();

            for (int i = 0; i < productItems.Count; i++)
            {

                int index = makeupItems[i].InnerText.IndexOf("+");

                if (index != -1)
                {
                    combos.Add(productItems[i].InnerText, new List<String> { makeupItems[i].InnerText.Substring(0, index - 1), makeupItems[i].InnerText.Substring(index + 2) });
                }
                else if (makeupItems[i].InnerText == " (basic element)")
                {
                    combos.Add(productItems[i].InnerText, new List<String> { null, null });
                }
                else
                {
                    combos.Add(productItems[i].InnerText, new List<String> { makeupItems[i].InnerText.Substring(2), makeupItems[i].InnerText.Substring(2) });
                }

            }

            //foreach(var combo in combos)
            //{
            //    Console.WriteLine(combo.Key);
            //    Console.WriteLine(combo.Value[0]);
            //    Console.WriteLine(combo.Value[1]);
            //}

            string json = JsonConvert.SerializeObject(combos, Formatting.Indented);
            File.WriteAllText(location, json);
        }

        public static void NewVer(string html, string location)
        {
            Console.WriteLine("Executing newer version");

            Dictionary<string, List<string>> combos = new Dictionary<string, List<string>>();

            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            //Console.WriteLine(html.ToString());

            var items = htmlDocument.DocumentNode.Descendants("div").ToList()
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("entry-content")).ToList()[0].Descendants("ol").ToList()[0].Descendants("li").ToList();

            if(items[0].InnerText == "Start with = Parrot")
            {
                Console.WriteLine("req met");

                List<string> addTtems = new List<string> { "Big",
                                            "Long Neck",
                                            "Long Tail",
                                            "Colorful",
                                            "Predator",
                                            "Swimming",
                                            "Jumping",
                                            "Fast",
                                            "Poisonous",
                                            "Horny",
                                            "Marsupial",
                                            "Furry",
                                            "Domestic",
                                            "Social",
                                            "Small",
                                            "Rodent",
                                            "Bloodsucker",
                                            "Hardworking",
                                            "Insect" };

                foreach(string item in addTtems)
                {
                    combos.Add(item, new List<string> { null, null });
                }

            }

            foreach (var item in items)
            {
                int indexPlus = item.InnerText.IndexOf("+");
                int indexEq = item.InnerText.IndexOf("=");

                if (indexPlus == -1)
                {
                    combos.Add(item.InnerText.Substring(indexEq + 2), new List<string> { null, null });
                }
                else
                {
                    combos.Add(item.InnerText.Substring(indexEq + 2), new List<string> { item.InnerText.Substring(0, indexPlus - 1), item.InnerText.Substring(indexPlus + 2, indexEq - indexPlus - 3) });
                }
            }

            foreach (var item in combos)
            {
                Console.WriteLine(item);
            }

            string json = JsonConvert.SerializeObject(combos, Formatting.Indented);
            File.WriteAllText(location, json);
        }
    }
}
