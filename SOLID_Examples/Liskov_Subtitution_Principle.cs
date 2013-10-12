using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Examples
{
    class Liskov_Subtitution_Principle
    {
        /*En vez de que tengamos que hacer una lista de ifs por cada posicion, deberiamos de usar polimorfismo para que
         * cada Pitcher y Catcher sepa que hacer instantaneamente al momento de llamar GotoPosition*/
        public void GotoPosition(BaseballPlayer b)
        {
            if (b is Pitcher)
            {
                //Go to the mound
            }
            else if (b is Catcher)
            {
                //Go to home plate
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

        public class Catcher : BaseballPlayer
        {
            public string CatcherGlove { get; set; }
            public string CatchingGear { get; set; }

            public Catcher(string n, Bat b, BattingAvg ba, string cglove, string cgear)
                : base(n, b, ba)
            {
                CatcherGlove = cglove;
                CatchingGear = cgear;
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



        public class Bat
        {
            public int size { get; set; }

            public Bat(int s)
            {
                size = s;
            }
        }
        public class BattingAvg
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
