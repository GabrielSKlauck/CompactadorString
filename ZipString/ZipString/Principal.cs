using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipString
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            Compactador comp = new Compactador();
            comp.Compactar("dddaaaaehfffnggtttjaaaa");
        }
    }
}
