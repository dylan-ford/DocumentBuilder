/* Dylan Ford
 * July 21/ 2020
 * interface for director class
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilderLibrary
{
    interface IDirector
    {
        void BuildBranch();
        void BuildLeaf();
        void CloseBranch();
    }
}
