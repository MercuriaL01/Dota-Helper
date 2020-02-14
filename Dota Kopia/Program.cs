using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dota_Kopia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<Calc>> all = new List<List<Calc>>();
            while (true)
            {
                string svar = Console.ReadLine();
                var enumsvar = Enum.Parse(typeof(HeroName), svar, true);   //true är där så man kan skriva stor och liten bokstav
                all.Add(GetHeroStats((int)enumsvar));
                Calculate(all);
                WriteStats(all.First());
            }
            Console.ReadKey();
        }

        private static List<Calc> GetHeroStats(int svar)
        {
            List<Calc> statlist = new List<Calc>();
            RestClient client = new
            RestClient("https://api.stratz.com/api/v1/Hero/" + svar + "/matchUp");
            RestRequest request = new RestRequest();

            IRestResponse response = client.Get(request);
            //Console.WriteLine(response.Content);

            RootObject info = JsonConvert.DeserializeObject<RootObject>(response.Content);
            foreach (var advantageitem in info.advantage)
            {
                foreach (var vsitem in advantageitem.vs)
                {
                    Calc calc = new Calc();
                    calc.heroId1 = vsitem.heroId1;
                    calc.heroId2 = vsitem.heroId2;
                    calc.wins = vsitem.wins;
                    statlist.Add(calc);
                    //Console.Write(vsitem.heroId1 + "    " + vsitem.heroId2 + "    " + vsitem.wins);
                    //Console.WriteLine();
                }
            }
            List<Calc> SortedList = statlist.OrderBy(o => o.wins).ToList();
            return SortedList;
        }
        private static void Calculate(List<List<Calc>> calcList)
        {
            if (calcList.Count == 2)
            {

                List<Calc> statlist = new List<Calc>();
                foreach (Calc item in calcList.First())
                {
                    double wins = 0.50;
                    if (calcList.Last().Any(x => x.heroId2 == item.heroId2))
                    {
                        wins = (calcList.Last().Find(x => x.heroId2 == item.heroId2).wins + item.wins) / 2;
                    }
                    Calc newCalc = new Calc();
                    newCalc.heroId2 = item.heroId2;
                    newCalc.wins = wins;
                    statlist.Add(newCalc);
                }
                calcList.Clear();
                calcList.Add(statlist.OrderBy(o => o.wins).ToList());
            }
        }
        private static void WriteStats(List<Calc> calcList)
        {
                foreach (var listitem in calcList)
                {
                    Console.WriteLine((HeroName)listitem.heroId2 + " has an average winrate of : " + (1 - listitem.wins) + " against the opponents");
                }
        }
    }
}
