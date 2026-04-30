using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDVDJ3D_Promedio1_Examen_Individual
{
    public class CombatSituation : Situation
    {
        private int enemyDamage;

        public CombatSituation(string description, int damage)
        {
            Description = description;
            enemyDamage = damage;

            choices.Add(new Choice("Atacar", (player) =>
            {
                Console.WriteLine("Atacas al enemigo.");
                player.Health -= enemyDamage / 2;
            }));

            choices.Add(new Choice("Defender", (player) =>
            {
                Console.WriteLine("Te defiendes.");
                player.Health -= enemyDamage / 4;
            }));

            choices.Add(new Choice("Huir", (player) =>
            {
                Console.WriteLine("Huyes pero recibes daño.");
                player.Health -= enemyDamage;
                player.Morality -= 5;
            }));
        }
    }
}
