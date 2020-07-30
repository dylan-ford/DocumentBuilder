/* Dylan Ford
 * July 21/ 2020
 * Concrete implementation of iBuilder for JSON documents
  */

using DocumentBuilderLibrary.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilderLibrary.Builder
{
    public class JSONBuilder : IBuilder
    {
        JBranch _jRoot;
        List<JBranch> _jBranchList;

        public JSONBuilder()
        {
            _jRoot = new JBranch("root");
            _jBranchList = new List<JBranch>();
            _jBranchList.Add(_jRoot);
        }
        public void BuildBranch(string name)
        {
            JBranch branch = new JBranch(name);
            _jBranchList[_jBranchList.Count() - 1].AddChild(branch);
            _jBranchList.Add(branch);
        }

        public void BuildLeaf(string name, string content)
        {
            _jBranchList[_jBranchList.Count() - 1].AddChild(new JLeaf(name, content));
        }

        public void CloseBranch()
        {
            _jBranchList.RemoveAt(_jBranchList.Count() - 1);
        }

        public IComposite GetDocument()
        {
            return _jRoot;
        }
    }
}
