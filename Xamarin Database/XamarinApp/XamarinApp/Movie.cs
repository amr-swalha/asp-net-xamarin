using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp
{
    public class Movie
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string MovieName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Length { get; set; }
    }
}
