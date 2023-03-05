using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listViewer
{
    public class datafield
    {
        public string coddatafield;
        public string typeoffield;
        public int sizeoffield;
        public int x;
        public int y;
        public string name;
        public string description;
        public string format;

        public datafield() { }
        public datafield(string pcoddatafield, string ptypeoffield, int psizeoffield, int px, int py, string pname, string pdescription, string pformat)
        {
            this.coddatafield = pcoddatafield;
            this.typeoffield = ptypeoffield;
            this.sizeoffield = psizeoffield;
            this.x = px;
            this.y = px;
            this.name = pname;
            this.description = pdescription;
            this.format = pformat;

        }


    }
}