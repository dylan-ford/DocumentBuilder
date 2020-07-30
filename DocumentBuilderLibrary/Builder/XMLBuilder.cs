/* Dylan Ford
 * July 21/ 2020
 * Concrete implementation of iBuilder for XML documents
  */
using DocumentBuilderLibrary.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilderLibrary.Builder
{
    public class XMLBuilder : IBuilder
    {
        XBranch _xRoot;
        List <XBranch> _xBranchList;

        public XMLBuilder()
        {
            _xRoot = new XBranch("root");
            _xBranchList = new List<XBranch>();
            _xBranchList.Add(_xRoot);
        }
        public void BuildBranch(string name)
        {
            XBranch branch = new XBranch(name);
            _xBranchList[_xBranchList.Count() - 1].AddChild(branch);
            _xBranchList.Add(branch);
        }

        public void BuildLeaf(string name, string content)
        {
            _xBranchList[_xBranchList.Count()-1].AddChild(new XLeaf(name, content));
        }

        public void CloseBranch()
        {
            //prevent closing of root
            if(_xBranchList.Count()>1)
                _xBranchList.RemoveAt(_xBranchList.Count() - 1);
        }

        public IComposite GetDocument()
        {
            return _xRoot;
        }
    }
}
