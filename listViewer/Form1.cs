using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        

        private void Form1_Load(object sender, EventArgs e)
        {
            //controls
            
            datafield d0 = new datafield("0", "TextBox", 50, 100, 10, "textboxnume", "numele de familie", "string");
            datafield d1 = new datafield("1", "Label", 50, 10, 10, "labelnume", "Numele de familie:", "string");
            datafield d2 = new datafield("2", "Button", 50, 200, 10, "btnnume", "save Numele de familie:", "string");

            //groups of controls
            groupofdatafields g    = new groupofdatafields();
            g.addDataFieldInGroup(d0);
            g.addDataFieldInGroup(d1);
            g.addDataFieldInGroup(d2);

            //list of groups of controls
            listofdatafieldsgroup lg = new listofdatafieldsgroup();
            lg.addDataFieldinList(g);

            //list of list of groups of controls
            listwithalldatafieldslists lal = new listwithalldatafieldslists();
            lal.addNewlistaswithallthedatafieldslists(lg);

            //inputformbuilder
            InputFormsBuilder ifb = new InputFormsBuilder();
            
            //set form 
            ifb.forma = this;
            lal.setForma(this);
            
            //show controls
            lal.showControls();


        }
    }
}
