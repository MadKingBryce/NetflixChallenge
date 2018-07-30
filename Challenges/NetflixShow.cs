using System;
namespace Challenges
{
    public class NetflixShow
    {
        //Properties
        public string title { get; set; }
        public string rating { get; set; }
        public int starRating { get; set; }
        public string genre { get; set; }



        //Constructor
        public NetflixShow(string theTitle, string theRating, int theStarRating, string theGenre)
        {
            title = theTitle;
            rating = theRating;
            starRating = theStarRating;
            genre = theGenre;
        }


        //Override of ToString
        public override string ToString()
        {
            string stringToReturn = $"{title}\t{rating}\t{starRating}\t{genre}";

            return stringToReturn;
        }
    }
}
