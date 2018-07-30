using System;
using System.Collections.Generic;

namespace Challenges
{
    public class NetflixRepo
    {
        List<NetflixShow> shows = new List<NetflixShow>();


        public void addShowToList(NetflixShow theShow)
        {
            shows.Add(theShow);
        }

        public List<NetflixShow> getList()
        {
            return shows;
        }

        public void printList(List<NetflixShow> theList)
        {
            foreach (NetflixShow show in theList)
            {
                Console.WriteLine(show);
            }
            Console.WriteLine("\n\n");
        }

        public void removeFromList(string theTitle)
        {
            int theIndex = shows.FindIndex(show => show.title == theTitle);
            shows.RemoveAt(theIndex);
        }
    }
}
