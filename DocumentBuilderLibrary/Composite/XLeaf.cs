/* Dylan Ford
 * July 21/ 2020
 * Concrete implementation of iComposite for XML leaves
  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilderLibrary.Composite
{
    class XLeaf : IComposite
    {
        string _name;
        string _content;

        public XLeaf(string name, string content)
        {
            _name = name;
            _content = content;
        }
        public void AddChild(IComposite child)
        {
            return;
        }

        public string Print(int depth)
        {
            for (int i = 0; i < depth; ++i)
            {
                Console.Write("\t");
            }
            Console.WriteLine($"<{_name}>{_content}<{_name}>");
            return "";
        }
    }
}
