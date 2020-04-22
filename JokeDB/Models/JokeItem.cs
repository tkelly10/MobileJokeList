using System;
using SQLite;

namespace JokeDB.Models
{
    public class JokeItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }        
        public string Content { get; set; }
    }
}


//[PrimaryKey, AutoIncrement]
//public int ID { get; set; }
//public string Name { get; set; }
//public string Notes { get; set; }
//public bool Done { get; set; }