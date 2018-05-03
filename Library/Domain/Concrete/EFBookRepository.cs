using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class EFBookRepository : IBookRepository
    {
        List<Book> books = new List<Book>();

        public IEnumerable<Book> Books
        {
            get
            {
                string dbname = "D://Учёба//Коды//LibraryRepos//Library//Domain//Library.db3";
                SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", dbname));
                connection.Open();

                SQLiteCommand command = new SQLiteCommand("SELECT * FROM 'Books';", connection);
                SQLiteDataReader reader = command.ExecuteReader();

                foreach (DbDataRecord book in reader)
                {
                    books.Add(new Book(book["Name"].ToString(), book["Author"].ToString(), book["Description"].ToString(), book["Genre"].ToString(), (decimal)book["Price"]));
                }

                connection.Close();

                return books;
            }
        }
    }
}
