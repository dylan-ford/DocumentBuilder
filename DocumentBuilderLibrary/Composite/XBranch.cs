/* Dylan Ford
 * July 21/ 2020
 * Concrete implementation of iComposite for XML branches
  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilderLibrary.Composite
{
    class XBranch : IComposite
    {
        private string _name;
        private List<IComposite> _xLeaves;

        public XBranch(string name)
        {
            _name = name;
            _xLeaves = new List<IComposite>();
        }

        public void AddChild(IComposite child)
        {
            _xLeaves.Add(child);
        }

        public string Print(int depth)
        {
            for(int i = 0; i<depth; ++i)
            {
                Console.Write("\t");
            }
            Console.WriteLine($"<{_name}>");

            for(int i = 0; i < _xLeaves.Count; ++i)
            {
                _xLeaves[i].Print(depth+1);
            }

            for (int i = 0; i < depth; ++i)
            {
                Console.Write("\t");
            }
            Console.WriteLine($"</{_name}>");

            return "";
        }
    }
}
