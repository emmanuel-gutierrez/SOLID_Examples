using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Examples
{
    class Dependency_Inversion_Principle
    {
        /*De esta manera, no se puede crear un Athlete pero con la interfaz de BaseballPlayer, podemos crear varios Athletes
         * que tengan esas habilidades y despues crear distintos tipos de BaseballPlayers que tambien tengan esas habilidades*/
        public abstract class Athlete
        {
            public string Name { get; set; }
            public void Jump() { }
            public void Slide() { }
            public void Run(){ }
        }

        public interface BaseballPlayer
        {
            public void Catch() { }
            public void Throw() { }
            public void Bat() { }

        }

        public class Pitcher : BaseballPlayer
        {
            public void Pitch() { }
            public void getInFightWithBatter() { }
        }
      
    }
}
