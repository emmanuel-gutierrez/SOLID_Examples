using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Examples
{
    class Single_Responsibility_Principle
    {
        /*Si tuviera esta clase y quisiera agregarle la habilidad de tener un guante de catcher y saber pichar
         * en vez de agregarselo a la clase BaseballPlayer, crearia una clase Catcher y otra de Pitcher que 
         * tengan como padre a BaseballPlayer */
        public class BaseballPlayer
        {
            public string Name { get; set; }
            public Bat bat { get; set; }
            public BattingAvg battingAvg { get; set; }
            //public string CatcherGlove { get; set; }
            //public List<string> Pitches = new List<string>();

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
