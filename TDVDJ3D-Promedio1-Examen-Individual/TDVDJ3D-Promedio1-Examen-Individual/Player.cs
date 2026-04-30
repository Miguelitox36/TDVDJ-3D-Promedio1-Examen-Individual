using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDVDJ3D_Promedio1_Examen_Individual
{
    public class Player
    {
        public string Name;
        public int Health;
        public int Morality;

        public Player(string name)
        {
            Name = name;
            Health = 100;
            Morality = 0;
        }

        public bool IsAlive()
        {
            return Health > 0;
        }
    }
}
