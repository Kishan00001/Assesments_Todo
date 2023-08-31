namespace Assignments.Common
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Genre { get; set; }
        public int MovieYear { get; set; }
        public string  Director { get; set; }
        public int Duration { get; set; }
        public Movie()
        {

        }
        public Movie(int MovieId,string MovieName, string Genre,int MovieYear, string Director, int duration)
        {
            this.MovieId = MovieId;
            this.MovieName = MovieName;
            this.Genre = Genre;
            this.MovieYear = MovieYear;
            this.Director = Director;
            this.Duration = Duration;
        }
    }
}