 using System;
using System.Collections.Generic;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            NetflixRepo theRepo = new NetflixRepo();
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("What do you want to do. Pick a number\n" +
                                  "1) Add to List\n" +
                                  "2) Remove From Lisst\n" +
                                  "3) View List\n" +
                                  "4) Exit");
                string userAnswer = Console.ReadLine();

                switch(userAnswer)
                {
                    
                    case "1":
                        while (true)
                        {
                            Console.WriteLine("Enter name of show");
                            string showName = Console.ReadLine();
                            Console.WriteLine("Enter rating of show");
                            string showRating = Console.ReadLine();
                            Console.WriteLine("Enter star rating of show");
                            int showStarRating = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Genre of Show");
                            string showGenre = Console.ReadLine();

                            NetflixShow userShow = new NetflixShow(showName, showRating, showStarRating, showGenre);

                            theRepo.addShowToList(userShow);

                            Console.WriteLine("Do you want to add another show?");
                            string theAnswer = Console.ReadLine();
                            if (theAnswer == "y")
                            {
                                //Do Nothing
                            }
                            else if (theAnswer == "n")
                            {
                                break;
                            }
                        }
                        break;
                    case "2":
                        while (true)
                        {
                            Console.WriteLine("What show do you want to remove?");
                            string show = Console.ReadLine();
                            theRepo.removeFromList(show);

                            Console.WriteLine("Do you want to delete a show?");
                            string theAnswer = Console.ReadLine();
                            if (theAnswer == "y") { }
                            else if (theAnswer == "n")
                            {
                                break;
                            }


                        }
                        break;
                    case "3":
                        theRepo.printList(theRepo.getList());
                        break;
                    case "4":
                        cont = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
