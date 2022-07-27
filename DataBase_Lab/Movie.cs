// Build a Movie class with two properties:  title and category. Both of these properties should be strings. 
// Create a constructor that takes two parameters: title and category.

class Movie
{
  public string Title { get; set; }
  public string Category { get; set; }

  public Movie(string title, string category)
  {
    Title = title;
    Category = category;
  }
  //in your Main, create a List<Movie> and store at least 10 movies there.

  List<Movie> movies = new List<Movie>();

  public Movie(List<Movie> movies)
  {
    this.movies = movies;
  }

  //in your Main, iterate through your List of Movies and print out the title and category of each movie.
  //Create a foreach loop that iterates through the list and prints out the title and category of each movie.

  public void PrintMovies()
  {
    foreach (Movie movie in movies)
    {
      Console.WriteLine($"{movie.Title} is a {movie.Category} movie.");
    }
    {
      Console.WriteLine("");
    }
  }
}
