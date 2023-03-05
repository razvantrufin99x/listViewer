using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listViewer
{
    public class groupofdatafields
    {
        public List<datafield> groupoffields = new List<datafield>();
        public groupofdatafields() { }
        public void addDataFieldInGroup(datafield d)
        {
            groupoffields.Add(d);
        }
    }
}
