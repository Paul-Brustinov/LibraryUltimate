using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUltimate.Model
{
    public class Book
    {
        public string Name { get; set; }
        public int Num { get; set; }
        public int FileSize { get; set; }
        public int Id { get; set; }
        public int Rate { get; set; }
        public DateTime Date { get; set; }
        public string FileName { get; set; }
        public string FileExt { get; set; }
        public string Lang { get; set; }


        public ObservableCollection<string> Authors { get; set; }
        public ObservableCollection<string> Genres { get; set; }
        public ObservableCollection<string> Series { get; set; }
        public ObservableCollection<string> KeyWords { get; set; }

        public Book()
        {
                
        }
    }
}
