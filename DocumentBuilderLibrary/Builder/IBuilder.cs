/* Dylan Ford
 * July 21/ 2020
 * Interface for builder classes
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilderLibrary
{
    public interface IBuilder
    {
        void BuildBranch(string name);
        void BuildLeaf(string name, string content);
        void CloseBranch();
        IComposite GetDocument();
    }
}
