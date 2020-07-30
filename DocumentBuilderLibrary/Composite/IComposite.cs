/* Dylan Ford
 * July 21/ 2020
 * Interface for branches and leaves
  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilderLibrary
{
    public interface IComposite
    {
        void AddChild(IComposite child);
        string Print(int depth);
    }
}
