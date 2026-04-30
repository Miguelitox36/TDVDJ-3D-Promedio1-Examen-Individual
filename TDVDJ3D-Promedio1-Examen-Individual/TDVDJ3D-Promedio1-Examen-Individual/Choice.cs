using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDVDJ3D_Promedio1_Examen_Individual
{
    public class Choice
    {
        public string Description;
        public Action<Player> Effect;

        public Choice(string description, Action<Player> effect)
        {
            Description = description;
            Effect = effect;
        }

        public void Execute(Player player)
        {
            Effect(player);
        }
    }
}
