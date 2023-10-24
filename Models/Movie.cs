namespace MoviesWebApp.Models
{
    public class Movie
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Runtime { get; set; }

        public Movie() 
        { 
        
        }
    }
}
