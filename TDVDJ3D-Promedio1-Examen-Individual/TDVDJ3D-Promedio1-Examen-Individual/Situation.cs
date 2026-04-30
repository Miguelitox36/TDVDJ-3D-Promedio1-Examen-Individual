using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDVDJ3D_Promedio1_Examen_Individual
{
    public abstract class Situation
    {
        public string Description { get; set; }
        protected List<Choice> choices = new List<Choice>();

        public void Play(Player player)
        {
            Console.WriteLine("\n" + Description);

            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + choices[i].Description);
            }

            int option = GetPlayerChoice();
            choices[option - 1].Execute(player);

            ShowPlayerStatus(player);
        }

        private int GetPlayerChoice()
        {
            int choice;
            Console.Write("Elige una opción: ");

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > choices.Count)
            {
                Console.WriteLine("Opción inválida, intenta de nuevo.");
                Console.Write("Elige una opción: ");
            }

            return choice;
        }

        private void ShowPlayerStatus(Player player)
        {
            Console.WriteLine("\nEstado actual:");
            Console.WriteLine("Vida: " + player.Health);
            Console.WriteLine("Moralidad: " + player.Morality);
        }
    }
}
