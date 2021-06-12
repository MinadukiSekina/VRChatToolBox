using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRChatToolBox
{
    internal class Avatar
    {
        internal Avatar(string name, string author) {
            Name = name;
            Author = author;
        }

        internal string Name { get; set; }
        internal string Author { get; set; }
    }
}
