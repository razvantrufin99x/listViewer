using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listViewer
{
    public class listwithalldatafieldslists
    {
        public List<listwithalldatafieldslists> listaswithallthedatafieldslists = new List<listwithalldatafieldslists>();
        public listwithalldatafieldslists() { }
        public void addNewlistaswithallthedatafieldslists(listwithalldatafieldslists l)
        {
            listaswithallthedatafieldslists.Add(l);
        }
    }
}
