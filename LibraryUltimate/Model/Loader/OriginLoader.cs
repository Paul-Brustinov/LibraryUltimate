using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUltimate.Model.Loader
{
    public class OriginLoader : ILoader
    {
        public Library Lib { get; set; }

        public string Path { get; set; }

        public OriginLoader(string _path){Path = _path;}

        public OriginLoader() : this(""){}
        


        public void Load(Library library)
        {
            var DirInfo = new DirectoryInfo(Path);

            foreach (var file in DirInfo.GetFiles().Where(fi=>fi.Name.Length >=17))
            {
                foreach (var l in File.ReadAllLines(Path + @"\" + file.Name))
                {
                    string[] line = l.Split((char) 4).ToArray();
                    ProcessLine(line, library);
                }
            }
        }

        private void ProcessLine(string[] line, Library library)
        {
            int id; int.TryParse(line[7], out id);
            if (library.Books.ContainsKey(id)) return;

            int num; int.TryParse(line[4], out num);
            int fileSize; int.TryParse(line[6], out fileSize);
            int rate; int.TryParse(line[12], out rate);
            DateTime date; DateTime.TryParse(line[10], out date);
            string authors = line[0];
            string genres = line[1];
            string name = line[2];
            string series = line[3];
            string fileName = line[5];
            string fileExt = line[9];
            string lang = line[11];
            string keyWords = line[13];

            Book book = new Book() { Name = name, Num = num, FileSize = fileSize, FileExt = fileExt, Lang = lang, Date = date, FileName = fileName, Id = id, Rate = rate };
            book.Authors  = ProcessColection(library.Authors, authors, book);
            book.KeyWords = ProcessColection(library.KeyWords, keyWords, book);
            book.Genres = ProcessColection(library.Genres, genres, book);
            book.Series = ProcessColection(library.Series, series, book);

            if (!library.Books.ContainsKey(id)) library.Books.Add(id, book);
        }

        private ObservableCollection<string> ProcessColection(Dictionary<string, List<Book>> coll, string str, Book book)
        {
            ObservableCollection<string> Collection = new ObservableCollection<string>(str.Split(':').Select(s => s = s.Replace(",", " ").Trim()).Where(s => s.Length > 0));

            Collection.ToList().ForEach(a =>
            {
                if (coll.ContainsKey(a))
                {
                    coll[a].Add(book);
                }
                else
                {
                    coll.Add(a, new List<Book>() { book });
                }
            });
            return Collection;
        }
    }
}
