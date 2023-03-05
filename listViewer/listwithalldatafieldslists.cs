using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listViewer
{
    public class listwithalldatafieldslists
    {
        public Form forma;
        public List<listofdatafieldsgroup> listaswithallthedatafieldslists = new List<listofdatafieldsgroup>();
        public listwithalldatafieldslists() {
         
        }
        public void setForma(Form f)
        {
            forma =  f;
        }
        public void addNewlistaswithallthedatafieldslists(listofdatafieldsgroup lg)
        {
            listaswithallthedatafieldslists.Add(lg);
        }
        private void saveDatas(object sender, EventArgs e)
        {

            ///

        }

        public void showControls()
        {
            for (int i = 0; i < listaswithallthedatafieldslists[0].datafieldsgrouplist[0].groupoffields.Count; i++)
            {
                if (listaswithallthedatafieldslists[0].datafieldsgrouplist[0].groupoffields[i].typeoffield == "Label")
                {
                    forma.Controls.Add(new Label());
                    forma.Controls[i].Left = listaswithallthedatafieldslists[0].datafieldsgrouplist[0].groupoffields[i].x;
                    forma.Controls[i].Top = listaswithallthedatafieldslists[0].datafieldsgrouplist[0].groupoffields[i].y;
                    forma.Controls[i].Name = listaswithallthedatafieldslists[0].datafieldsgrouplist[0].groupoffields[i].name;
                    forma.Controls[i].Text = listaswithallthedatafieldslists[0].datafieldsgrouplist[0].groupoffields[i].description;
                }
               else if (listaswithallthedatafieldslists[0].datafieldsgrouplist[0].groupoffields[i].typeoffield == "TextBox")
                {
                    forma.Controls.Add(new TextBox());
                    forma.Controls[i].Left = listaswithallthedatafieldslists[0].datafieldsgrouplist[0].groupoffields[i].x;
                    forma.Controls[i].Top = listaswithallthedatafieldslists[0].datafieldsgrouplist[0].groupoffields[i].y;
                    forma.Controls[i].Name = listaswithallthedatafieldslists[0].datafieldsgrouplist[0].groupoffields[i].name;
                    forma.Controls[i].Text = listaswithallthedatafieldslists[0].datafieldsgrouplist[0].groupoffields[i].description;
                }
                else if (listaswithallthedatafieldslists[0].datafieldsgrouplist[0].groupoffields[i].typeoffield == "Button")
                {
                    forma.Controls.Add(new Button());
                    forma.Controls[i].Left = listaswithallthedatafieldslists[0].datafieldsgrouplist[0].groupoffields[i].x;
                    forma.Controls[i].Top = listaswithallthedatafieldslists[0].datafieldsgrouplist[0].groupoffields[i].y;
                    forma.Controls[i].Name = listaswithallthedatafieldslists[0].datafieldsgrouplist[0].groupoffields[i].name;
                    forma.Controls[i].Text = listaswithallthedatafieldslists[0].datafieldsgrouplist[0].groupoffields[i].description;
                    forma.Controls[i].Click += new System.EventHandler(this.saveDatas);
                }
            }
        }

    }
}
