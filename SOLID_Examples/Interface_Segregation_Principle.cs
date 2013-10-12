using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Examples
{
    class Interface_Segregation_Principle
    {
        /*Si quiero que mi Catcher pueda taclear un corredor y es algo bastante complejo, en vez que integrarlo a BaseballPlayer
         * podemos hacer una interface que podamos agregarle a catcher para que solo el pueda taclear corredores*/

        public interface Tackle
        {
            public void TackleBaserunner();
            public void TackleUmpire();
        }
   
        public class Catcher : BaseballPlayer,Tackle
        {
            public string CatcherGlove { get; set; }
            public string CatchingGear { get; set; }

            public Catcher(string n, Bat b, BattingAvg ba, string cglove, string cgear)
                : base(n, b, ba)
            {
                CatcherGlove = cglove;
                CatchingGear = cgear;
            }

            public void TackleBaserunner()
            {
                //Do the Tackle to BaseRunner
            }

            public void TackleUmpire()
            {
               //Do the Tackle to Umpire and get kicked out of the game
            }
        }

        public class Pitcher : BaseballPlayer
        {
            public List<string> Pitches = new List<string>();

            public Pitcher(string n, Bat b, BattingAvg ba, List<string> p)
                : base(n, b, ba)
            {
                Pitches = p;
            }
        }

        public class BaseballPlayer
        {
            public string Name { get; set; }
            public Bat bat { get; set; }
            public BattingAvg battingAvg { get; set; }

            public BaseballPlayer(string n, Bat b, BattingAvg ba)
            {
                Name = n;
                bat = b;
                battingAvg = ba;
            }
        }

        public class Bat
        {
            public int size { get; set; }

            public Bat(int s)
            {
                size = s;
            }
        }
        class BattingAvg
        {
            public double atBats { get; set; }
            public double hits { get; set; }

            public BattingAvg(double ab, double h)
            {
                atBats = ab;
                hits = h;
            }

            public double getBattingAvg()
            {
                return hits / atBats;
            }
        }
    }
}
