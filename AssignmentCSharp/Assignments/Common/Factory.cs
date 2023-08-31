using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Common
{
    interface IMovieDatabase : IEnumerable<Movie>
    {
        void AddingMovie();
        void Updating(int id,Movie mov);
        void Deleting(int id);
        int Count { get; }
        Movie this[int index] { get; }
    }
    class Factory
    {
        public static IMovieDatabase GetComponent(string type)
        {
            switch (type.ToLower())
            {
                case "movie": return new MovieDatabase();
                default: return new MovieDatabase();
            }
        }
    }

}