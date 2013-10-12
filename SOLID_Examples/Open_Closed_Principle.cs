using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Examples
{
    class Open_Closed_Principle
    {
        /*Si queremos que el BaseballPlayer pueda lanzar, batear, brincar y barrerse, sin tener que modificar la clase
         * BaseballPlayer, podemos hacerlo que extienda de una clase Athlete que tenga la habilidad de hacer estas cosas,
         * en vez de agregarle funciones a BaseballPlayer y alterar su estructura
         */

        public class Athlete
        {
            public void Throw() { }
            public void Bat() { }
            public void Jump() { }
            public void Slide() { }
        }

        public class BaseballPlayer:Athlete
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
