/* Dylan Ford
 * July 21/ 2020
 * Concrete implementation of iDirector to build XML and JSON documents
  */

using DocumentBuilderLibrary.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentBuilderLibrary.Director
{
    public class Director : IDirector
    {
        public IBuilder _builder;
        public string _name;
        public string _content;

        public Director()
        {

        }
        public Director(IBuilder builder)
        {
            _builder = builder;
        }
        //builder.getDocument.print(0)
        public void BuildBranch()
        {
            _builder.BuildBranch(_name);
        }
        public void BuildLeaf()
        {
            _builder.BuildLeaf(_name, _content);
        }
        public void CloseBranch()
        {
            _builder.CloseBranch();
        }
    }
}
