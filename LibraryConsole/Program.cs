using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryUltimate.Model.Loader;
using LibraryUltimate.Model;

namespace LibraryConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);

            Library library = new Library();
            OriginLoader loader = new OriginLoader(AppDomain.CurrentDomain.BaseDirectory + @"\SourceInfo\");
            library.LibLoader = loader;
            library.Load();
            foreach (var book in library.Books.Where(b=>b.Value.Name.Contains("Мастер")))
            {
                Console.WriteLine(book.Value.Name);
                foreach (var author in book.Value.Authors)
                {
                    Console.WriteLine("auth:{0}", author);
                }
            }
        }
    }
}
