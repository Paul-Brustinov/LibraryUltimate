using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryUltimate.Model.Loader;

namespace LibraryUltimate.Model
{
    public class Library
    {
        public Dictionary<int, Book> Books { get; set; }
        public Dictionary<string, List<Book>> Authors { get; set; }
        public Dictionary<string, List<Book>> Genres { get; set; }
        public Dictionary<string, List<Book>> Series { get; set; }
        public Dictionary<string, List<Book>> KeyWords { get; set; }

        public Dictionary<int, String> ImportedFiles { get; set; }
        
        public ILoader LibLoader { get; set; }

        public Library()
        {
            Books = new Dictionary<int, Book>();
            Authors  = new Dictionary<string, List<Book>>();
            Genres   = new Dictionary<string, List<Book>>();
            Series   = new Dictionary<string, List<Book>>();
            KeyWords = new Dictionary<string, List<Book>>();

            ImportedFiles = new Dictionary<int, string>();

        }

        public void Load()
        {
            LibLoader.Load(this);
        }
    }
}
