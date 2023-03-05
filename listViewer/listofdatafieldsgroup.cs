using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listViewer
{
    public class listofdatafieldsgroup
    {
        public List<groupofdatafields> datafieldsgrouplist = new List<groupofdatafields>();
        public void addDataFieldinList(groupofdatafields d)
        {
            datafieldsgrouplist.Add(d);
        }
        public listofdatafieldsgroup() { }
    }
}
