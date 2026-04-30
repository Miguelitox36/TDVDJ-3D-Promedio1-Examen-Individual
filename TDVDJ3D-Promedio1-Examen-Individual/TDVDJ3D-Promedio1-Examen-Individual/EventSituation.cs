using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDVDJ3D_Promedio1_Examen_Individual
{
    public class EventSituation : Situation
    {
        public EventSituation(string description)
        {
            Description = description;
        }

        public void AddChoice(Choice choice)
        {
            choices.Add(choice);
        }
    }
}
