using System;

namespace AttMusica
{
    class Program
    {
        static void refrao(){
            // Método criado para não repetir esses códigos toda vez que for executá-los.

            Console.BackgroundColor=ConsoleColor.White;
            Console.ForegroundColor=ConsoleColor.Black;
        }
        static void Main(string[] args)
        {
            // Exercício 4 - Faça um programa que exiba uma letra de música a sua escolha. Utilize cores em destaque no título e nos refrões.

            Console.BackgroundColor=ConsoleColor.DarkGray;
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            Console.WriteLine("Nome da Canção: Can You Feel My Heart?");
            Console.ForegroundColor=ConsoleColor.Green;
            Console.Write("Artista: Bring Me The Horizon");

            Console.ResetColor();

            // Refrão
            
            refrao();
            Console.Write("\n\nCan you hear the silence?\nCan you see the dark?\nCan you fix the broken?\nCan you feel, can you feel my heart?"); // Uso do Write, no lugar do WriteLine, para que o background desta frase não ultrapasse a ultima linha

            // Volta a letra normal

            Console.ResetColor(); // Volta a cor ao estado original
            Console.WriteLine("\n\nCan you help the hopeless?\nWell, I'm begging on my knees\nCan you save my bastard soul?\nWill you wait for me?\n");

            Console.WriteLine("I'm sorry, brothers\nSo sorry, lover\nForgive me, father\nI love you, mother\n");

            // Refrão

            refrao();
            Console.Write("Can you hear the silence?\nCan you see the dark?\nCan you fix the broken?\nCan you feel my heart?\nCan you feel my heart?\nCan you feel my heart?\nCan you feel my heart?");

            // Volta a letra normal

            Console.ResetColor();
            Console.WriteLine("\n\nI'm scared to get close and I hate being alone\nI long for that feeling to not feel at all\nThe higher I get, the lower I'll sink\nI can't drown my demons, they know how to swim\n");

            Console.WriteLine("I'm scared to get close and I hate being alone\nI long for that feeling to not feel at all\nThe higher I get, the lower I'll sink\nI can't drown my demons, they know how to swim\n");

            Console.WriteLine("I'm scared to get close and I hate being alone\nI long for that feeling to not feel at all\nThe higher I get, the lower I'll sink\nI can't drown my demons, they know how to swim\n");

            // Refrão

            refrao();
            Console.Write("Can you feel my heart?\nCan you hear the silence?\nCan you see the dark?\nCan you fix the broken?\nCan you feel, can you feel my heart?");

            Console.ResetColor();
            Console.Write("\n\nPressione qualquer tecla. . .");
            Console.ReadKey(); 
        }
    }
}
