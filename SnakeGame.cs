using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading;



class Program

{

    static void Main()

    {

        Console.WindowHeight = 16;

        Console.WindowWidth = 32;

        int screenwidth = Console.WindowWidth;

        int screenheight = Console.WindowHeight;

        Random randomnummer = new Random();

        Pixel hoofd = new Pixel();

        hoofd.xPos = screenwidth / 2;

        hoofd.yPos = screenheight / 2;

        hoofd.schermKleur = ConsoleColor.Red;
        

        string movement = "RIGHT";

        List<int> telje = new List<int>();

        int score = 0;

        //Pixel hoofd = new Pixel();

        hoofd.xPos = screenwidth / 2;

        hoofd.yPos = screenheight / 2;

        hoofd.schermKleur = ConsoleColor.Red;



        List<int> teljePositie = new List<int>();



        teljePositie.Add(hoofd.xPos);

        teljePositie.Add(hoofd.yPos);



        DateTime tijd = DateTime.Now;

        string obstacle = "*";

        int obstacleXpos = randomnummer.Next(1, screenwidth);

        int obstacleYpos = randomnummer.Next(1, screenheight);

        while (true)

        {

            
                

           

            Thread.Sleep(50);

        }

    }

}



public class Pixel

{

    public int xPos { get; set; }

    public int yPos { get; set; }

    public ConsoleColor schermKleur { get; set; }

    public string karacter { get; set; }

}



public class Obstakel

{

    public int Xpos { get; set; }

    // ?

    public ConsoleColor schermKleur { get; set; }

    public string karacter { get; set; }

}