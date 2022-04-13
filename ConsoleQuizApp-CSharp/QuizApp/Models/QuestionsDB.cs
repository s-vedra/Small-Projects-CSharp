using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class QuestionsDB
    {
        public static List<Questions> questions = new List<Questions>()
        {
             new Questions("What is the capital of Tasmania?" , new List<string>(){ "1.Dodoma \n2.Hobart \n3.Launceston \n4.Wellington" } ,2),
             new Questions("What is the tallest building in the Republic of the Congo?",
             new List<string>(){ "1.Kinshasa Democratic Republic of the Congo Temple \n2.Palais de la Nation \n3.Kongo Trade Centre \n4.Nabemba Tower" }, 4),
             new Questions("Which of these is not one of Pluto's moons?",new List<string>(){"1.Styx \n2.Hydra \n3.Nix \n4.Lugia"},3 ),
             new Questions("What is the smallest lake in the world?", new List<string>(){"1.Onega Lake \n2.Benxi Lake \n3.Kivu Lake \n4.Wakatipu Lake"}, 2),
             new Questions("What country has the largest population of alpacas?",  new List<string>(){ "1.Chad \n2.Peru \n3.Australia \n4.Niger"}, 2)
        };
    }
}
