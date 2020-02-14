using System.Collections.Generic;
namespace Dota_Kopia
{

    public class With
    {
        public int heroId1 { get; set; }
        public int heroId2 { get; set; }
        public int week { get; set; }
        public int rank { get; set; }
        public int matchCount { get; set; }
        public int kills { get; set; }
        public int deaths { get; set; }
        public int assists { get; set; }
        public int networth { get; set; }
        public int duration { get; set; }
        public int firstBloodTime { get; set; }
        public int cs { get; set; }
        public int dn { get; set; }
        public int goldEarned { get; set; }
        public int xp { get; set; }
        public long heroDamage { get; set; }
        public int towerDamage { get; set; }
        public int heroHealing { get; set; }
        public int level { get; set; }
        public double synergy { get; set; }
        public double wins { get; set; }
    }

    public class V
    {
        public int heroId1 { get; set; }
        public int heroId2 { get; set; }
        public int week { get; set; }
        public int rank { get; set; }
        public int matchCount { get; set; }
        public int kills { get; set; }
        public int deaths { get; set; }
        public int assists { get; set; }
        public int networth { get; set; }
        public int duration { get; set; }
        public int firstBloodTime { get; set; }
        public int cs { get; set; }                                                                                                                     
        public int dn { get; set; }
        public int goldEarned { get; set; }
        public int xp { get; set; }
        public long heroDamage { get; set; }
        public long towerDamage { get; set; }
        public int heroHealing { get; set; }
        public int level { get; set; }
        public double synergy { get; set; }
        public double wins { get; set; }
    }

    public class Advantage
    {
        public List<With> with { get; set; }
        public int matchCountWith { get; set; }
        public List<V> vs { get; set; }
        public int matchCountVs { get; set; }
    }

    public class With2
    {
        public int heroId1 { get; set; }
        public int heroId2 { get; set; }
        public int week { get; set; }
        public int rank { get; set; }
        public int matchCount { get; set; }
        public int kills { get; set; }
        public int deaths { get; set; }
        public int assists { get; set; }
        public int networth { get; set; }
        public int duration { get; set; }
        public int firstBloodTime { get; set; }
        public int cs { get; set; }
        public int dn { get; set; }
        public int goldEarned { get; set; }
        public int xp { get; set; }
        public long heroDamage { get; set; }
        public long towerDamage { get; set; }
        public int heroHealing { get; set; }
        public int level { get; set; }
        public double synergy { get; set; }
        public double wins { get; set; }
    }

    public class V2
    {
        public int heroId1 { get; set; }
        public int heroId2 { get; set; }
        public int week { get; set; }
        public int rank { get; set; }
        public int matchCount { get; set; }
        public int kills { get; set; }
        public int deaths { get; set; }
        public int assists { get; set; }
        public int networth { get; set; }
        public int duration { get; set; }
        public int firstBloodTime { get; set; }
        public int cs { get; set; }
        public int dn { get; set; }
        public int goldEarned { get; set; }
        public int xp { get; set; }
        public long heroDamage { get; set; }
        public int towerDamage { get; set; }
        public int heroHealing { get; set; }
        public int level { get; set; }
        public double synergy { get; set; }
        public double wins { get; set; }
    }

    public class Disadvantage
    {
        public List<With2> with { get; set; }
        public int matchCountWith { get; set; }
        public List<V2> vs { get; set; }
        public int matchCountVs { get; set; }
    }

    public class RootObject
    {
        public List<Advantage> advantage { get; set; }
        public List<Disadvantage> disadvantage { get; set; }
    }
}