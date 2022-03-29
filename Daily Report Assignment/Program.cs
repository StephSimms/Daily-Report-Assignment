using System;


    class Program
    {
        static void Main()
        {
        Console.WriteLine("Academy of Learning Career College");
        Console.WriteLine("Student Daily Report");

        Console.WriteLine("What course are you in?");
        string yourCourse = Console.ReadLine();
        Console.WriteLine("Your course is: " + yourCourse);
        Console.ReadLine();

        Console.WriteLine("What page number?");
        string pageNumber = Console.ReadLine();
        Console.WriteLine("Your page number is: " + pageNumber);
        Console.ReadLine();

        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\" ");
        bool isHelp = false;
        Console.WriteLine("OK, sounds like you've got it!" + isHelp);
        Console.ReadLine();
        bool isHelp = true;
        Console.WriteLine("OK, help is on the way!" + isHelp);
        Console.ReadLine();

        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string myFeedback = Console.ReadLine();
        Console.WriteLine("Thank you for the feedback." + myFeedback);
        Console.ReadLine();
        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
        string myFeed = Console.ReadLine();
        Console.WriteLine("Thank you and have a nice day." + myFeed);
        Console.ReadLine();


        Console.WriteLine("How many hours did you study today?");
        string hoursStudied = Console.ReadLine();
        Console.WriteLine("You've studied" + hoursStudied);
        Console.ReadLine();

        Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");
        Console.ReadLine();


        

    }
    }

