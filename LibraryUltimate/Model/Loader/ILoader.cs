using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUltimate.Model.Loader
{
    public interface ILoader
    {
        Library Lib { get; set; }
        void Load(Library library);
    }
}
