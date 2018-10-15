using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broker
{
    class Theme
    {
        public int id { get; set; }
        public string name { get; set; }
        public string website { get; set; }
        public string author { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"\tTheme id = {id}\n");
            sb.Append($"\tname = {name}\n");
            sb.Append($"\twebsite = {website}\n");
            sb.Append($"\tauthor = {author}\n");
            return sb.ToString();
        }

    }
}
