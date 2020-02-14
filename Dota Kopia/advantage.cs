using System;
using System.Collections.Generic;
using System.Text;

namespace Dota_Kopia
{
    class advantage
    { 
        public Stats stats;


        public int hero1
        {
            get { return stats.heroId1; }
        }
        public int hero2
        {
            get { return stats.heroId2; }
        }
        public double wins
        {
            get { return stats.wins; }
        }
    }



}

