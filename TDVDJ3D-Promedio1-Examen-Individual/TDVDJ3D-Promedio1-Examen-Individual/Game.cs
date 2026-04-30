using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDVDJ3D_Promedio1_Examen_Individual
{
    public class Game
    {
        private Player player;
        private List<Situation> situations = new List<Situation>();

        public void Start()
        {
            Console.Clear();
            Console.WriteLine("AVENTURA DE TEXTO");
            Console.Write("Ingresa tu nombre: ");
            string name = Console.ReadLine();

            player = new Player(name);

            CreateSituations();
            PlayGame();
        }

        private void CreateSituations()
        {
            situations.Clear();

            EventSituation s1 = new EventSituation("Encuentras a un viajero herido en el camino.");
            s1.AddChoice(new Choice("Ayudarlo", p =>
            {
                Console.WriteLine("Lo ayudas y te agradece.");
                p.Morality += 10;
            }));

            s1.AddChoice(new Choice("Ignorarlo", p =>
            {
                Console.WriteLine("Sigues tu camino.");
                p.Morality -= 5;
            }));

            CombatSituation s2 = new CombatSituation("Un bandido te ataca.", 30);

            EventSituation s3 = new EventSituation("Encuentras un cofre lleno de oro.");
            s3.AddChoice(new Choice("Compartirlo con otros", p =>
            {
                Console.WriteLine("Compartes el tesoro.");
                p.Morality += 10;
            }));

            s3.AddChoice(new Choice("Quedártelo todo", p =>
            {
                Console.WriteLine("Te quedas con todo.");
                p.Morality -= 10;
            }));

            situations.Add(s1);
            situations.Add(s2);
            situations.Add(s3);
        }

        private void PlayGame()
        {
            foreach (Situation situation in situations)
            {
                situation.Play(player);

                if (!player.IsAlive())
                {
                    GameOver();
                    return;
                }
            }

            ShowEnding();
        }

        private void GameOver()
        {
            Console.WriteLine("\nHas muerto...");
            Console.Write("¿Quieres reintentar? (s/n): ");
            string input = Console.ReadLine().ToLower();

            if (input == "s")
            {
                Start();
            }
        }

        private void ShowEnding()
        {
            Console.WriteLine("\nFINAL");

            if (player.Morality >= 10)
            {
                Console.WriteLine("Final Bueno: Te conviertes en un héroe legendario.");
            }
            else if (player.Morality >= 0)
            {
                Console.WriteLine("Final Neutral: Sobrevives, pero nadie recuerda tu nombre.");
            }
            else
            {
                Console.WriteLine("Final Malo: Caes en la oscuridad.");
            }

            Console.WriteLine("\nFin del juego.");
        }
    }
}
