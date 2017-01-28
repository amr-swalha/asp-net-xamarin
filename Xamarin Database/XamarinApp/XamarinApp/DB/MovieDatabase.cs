using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace XamarinApp.DB
{
    public class MovieDatabase
    {
        private SQLiteConnection Database;
        static object locker = new object();
        public MovieDatabase()
        {
            Database = DependencyService.Get<ISQLite>().GetConnection();
            Database.CreateTable<Movie>();
        }

        public int SaveContact(Movie movie)
        {
            lock (locker)
            {
                if (movie.Id != 0)
                {
                    Database.Update(movie);
                    return movie.Id;
                }
                else
                {
                    return Database.Insert(movie);
                }
            }
        }

        public IEnumerable<Movie> GetMovies()
        {
            lock (locker)
            {
                return (from c in Database.Table<Movie>() select c).ToList();
            }
        }

        public Movie GetMovie(int id)
        {
            lock (locker)
            {
                return Database.Table<Movie>().FirstOrDefault(x => x.Id == id);
            }
        }

        public int DeleteMovie(int id)
        {
            lock (locker)
            {
                return Database.Delete<Movie>(id);
            }
        }
    }
}
