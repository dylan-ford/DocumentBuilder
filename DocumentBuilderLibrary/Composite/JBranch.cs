/* Dylan Ford
 * July 21/ 2020
 * Concrete implementation of iComposite for JSON branches
  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilderLibrary.Composite
{
    class JBranch : IComposite
    {
        public string _name;
        public List<IComposite> _jLeaves;

        public JBranch(string name)
        {
            _name = name;
            _jLeaves = new List<IComposite>();
        }

        public void AddChild(IComposite child)
        {
            _jLeaves.Add(child);
        }

        public string Print(int depth)
        {
            if(_name != "root")
            {
                for (int i = 0; i < depth; ++i)
                {
                    Console.Write("\t");
                }
                Console.WriteLine($"'{_name}' :");
            }            
            for (int i = 0; i < depth; ++i)
            {
                Console.Write("\t");
            }
            Console.WriteLine("{");

            for (int i = 0; i < _jLeaves.Count; ++i)
            {
                _jLeaves[i].Print(depth + 1);
            }

            for (int i = 0; i < depth; ++i)
            {
                Console.Write("\t");
            }
            
            //handle hanging comma at end of doc
            if(_name != "root")
                Console.WriteLine("},");
            else
                Console.WriteLine("}");

            return "";
        }
    }
}
