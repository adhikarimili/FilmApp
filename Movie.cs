using System;
using System.Collections.Generic;
using System.Text;

namespace FilmApp
{/// <summary>
/// This is a Film lebrary where user can add movies and give rating.
/// </summary>

    class Movie
    {
        #region Variable

        /// <summary>
        /// Autogenrate a Movie numbber
        /// </summary>

        public static int lastMovieNumber = 0;       


        #endregion

        #region Properties
            
        public string  MovieNumber { get; set; }
        /// <summary>
        /// Name of the movie
        /// </summary>
        public string MovieName { get; set; }

        /// <summary>
        /// lenght of movie
        /// </summary>
        public int MovieLenght { get; set; }

        /// <summary>
        /// Rating of the Movie
        /// </summary>
        public Decimal MovieRating { get; set; }

        /// <summary>
        /// Relase Date of the Movie
        /// </summary>
        public DateTime MovieRelaseDate { get; set; }

        #endregion

        #region Constructor
        public Movie()
        {
            MovieNumber = lastMovieNumber++;
            MovieRelaseDate = DateTime.Now;
        }
        #endregion

        #region Method
        ///<summary>
        /// new Movie added in the movie library
        ///</summary>
        ///<param name = "movie is added"></param>
        
        public void LastMovieNumber(int movie)
        {
            MovieNumber += movie;
        }

        #endregion

    }
}
