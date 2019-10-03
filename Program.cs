using System;

namespace FilmApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instance of an Movie == Object
            var movie = new Movie
            {
                MovieNumber = "1234",
                MovieName = "abcdef"
            };
            movie.LastMovieNumber(1);

            Console.WriteLine($"MovieNumber: {movie.MovieNumber}," +
                $" MovieName : {movie.MovieName}," +
                $" MovieRating: {movie.MovieRating}, " +
                $"MovieRaleaseDate: {movie.MovieRelaseDate}, " +
                $"MovieLenght: {movie.MovieLenght}");
        }
    }
}
// account.Deposit(2003.234m)