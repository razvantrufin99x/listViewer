using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listViewer
{
    public  class formBuilder
    {
        //a list
        public List<string> list = new List<string>();


        //declare
        public InputFormsBuilder ifb;

        //counter of Controlls added
        public int i = 0;


        //i can not include this in a sub module 
        private void addDate(object sender, EventArgs e)
        {
            //trebuie sa preia data din datetimepicker not datetime.now
            //25 inseamna controlul i-25 unde i este numarul tuturor controlelor din lista ifb
            ifb.listControls[i - 27].Text = DateTime.Now.ToString();

        }


        private void saveDatas(object sender, EventArgs e)
        {

            for (int k = 0; k < ifb.listControls.Count; k++)
            {

                list.Add(ifb.listControls[k].Text);
                printDatasToDebugWindow();
                //this.Refresh();
            }

        }
        public void printDatasToDebugWindow()
        {
            for (int j = 0; j < list.Count; j++)
            {

               // this.textBox1.Text += "\r\n" + list[j].ToString() + "\r\n";
            }
        }


        /*
         private void Form1_Load(object sender, EventArgs e)
        {
            //init
            ifb = new InputFormsBuilder(this);

            //manual creation but i add new classes for automatic creation based of reading datas from a list or classes fields

            //field persoana.codpersoana
            //add a label
            ifb.addControl(new Label());
            i++;
            ifb.listControls[i - 1].Text = "CodPersoana:";
            ifb.listControls[i - 1].Left = 10;
            ifb.listControls[i - 1].Top = 20;

            //add a textbox
            ifb.addControl(new TextBox());
            i++;
            ifb.listControls[i - 1].Text = "codul persoanei";
            ifb.listControls[i - 1].Left = 100;
            ifb.listControls[i - 1].Top = 20;

            //add a button
            ifb.addControl(new Button());
            i++;
            ifb.listControls[i - 1].Text = "Adauga";
            ifb.listControls[i - 1].Left = 200;
            ifb.listControls[i - 1].Top = 20;

            //field persoana.nume
            //add a label
            ifb.addControl(new Label());
            i++;
            ifb.listControls[i - 1].Text = "Nume:";
            ifb.listControls[i - 1].Left = 10;
            ifb.listControls[i - 1].Top = 40;

            //add a textbox
            ifb.addControl(new TextBox());
            i++;
            ifb.listControls[i - 1].Text = "numele de familie";
            ifb.listControls[i - 1].Left = 100;
            ifb.listControls[i - 1].Top = 40;

            //add a button
            ifb.addControl(new Button());
            i++;
            ifb.listControls[i - 1].Text = "Adauga";
            ifb.listControls[i - 1].Left = 200;
            ifb.listControls[i - 1].Top = 40;

            //field prenume
            //add a label
            ifb.addControl(new Label());
            i++;
            ifb.listControls[i - 1].Text = "Prenume:";
            ifb.listControls[i - 1].Left = 10;
            ifb.listControls[i - 1].Top = 60;

            //add a textbox
            ifb.addControl(new TextBox());
            i++;
            ifb.listControls[i - 1].Text = "prenumele";
            ifb.listControls[i - 1].Left = 100;
            ifb.listControls[i - 1].Top = 60;

            //add a button
            ifb.addControl(new Button());
            i++;
            ifb.listControls[i - 1].Text = "Adauga";
            ifb.listControls[i - 1].Left = 200;
            ifb.listControls[i - 1].Top = 60;


            //field.datanasterii
            //add a label
            ifb.addControl(new Label());
            i++;
            ifb.listControls[i - 1].Text = "datanasterii:";
            ifb.listControls[i - 1].Left = 10;
            ifb.listControls[i - 1].Top = 80;

            //add a textbox
            ifb.addControl(new TextBox());
            i++;
            ifb.listControls[i - 1].Text = "datanasterii";
            ifb.listControls[i - 1].Left = 100;
            ifb.listControls[i - 1].Top = 80;

            //add a button
            ifb.addControl(new Button());
            i++;
            ifb.listControls[i - 1].Text = "Adauga";
            ifb.listControls[i - 1].Left = 200;
            ifb.listControls[i - 1].Top = 80;

            //add a datetimepicker
            ifb.addControl(new DateTimePicker());
            i++;
            ifb.listControls[i - 1].Left = 300;
            ifb.listControls[i - 1].Top = 80;
            ifb.listControls[i - 1].Text = DateTime.Now.ToString();

            //add a button
            ifb.addControl(new Button());
            i++;
            ifb.listControls[i - 1].Text = "Timpul";
            ifb.listControls[i - 1].Left = 500;
            ifb.listControls[i - 1].Top = 80;
            ifb.listControls[i - 1].Click += new System.EventHandler(this.addDate);

            //field adresa
            //add a label
            ifb.addControl(new Label());
            i++;
            ifb.listControls[i - 1].Text = "Adresa:";
            ifb.listControls[i - 1].Left = 10;
            ifb.listControls[i - 1].Top = 100;

            //add a textbox
            ifb.addControl(new TextBox());
            i++;
            ifb.listControls[i - 1].Text = "adresa completa";
            ifb.listControls[i - 1].Left = 100;
            ifb.listControls[i - 1].Top = 100;

            //add a button
            ifb.addControl(new Button());
            i++;
            ifb.listControls[i - 1].Text = "Adauga";
            ifb.listControls[i - 1].Left = 200;
            ifb.listControls[i - 1].Top = 100;




            //field judet
            //add a label
            ifb.addControl(new Label());
            i++;
            ifb.listControls[i - 1].Text = "Judet:";
            ifb.listControls[i - 1].Left = 10;
            ifb.listControls[i - 1].Top = 120;

            //add a textbox
            ifb.addControl(new TextBox());
            i++;
            ifb.listControls[i - 1].Text = "judetul";
            ifb.listControls[i - 1].Left = 100;
            ifb.listControls[i - 1].Top = 120;

            //add a button
            ifb.addControl(new Button());
            i++;
            ifb.listControls[i - 1].Text = "Adauga";
            ifb.listControls[i - 1].Left = 200;
            ifb.listControls[i - 1].Top = 120;



            //field oras
            //add a label
            ifb.addControl(new Label());
            i++;
            ifb.listControls[i - 1].Text = "Oras:";
            ifb.listControls[i - 1].Left = 10;
            ifb.listControls[i - 1].Top = 140;

            //add a textbox
            ifb.addControl(new TextBox());
            i++;
            ifb.listControls[i - 1].Text = "orasul";
            ifb.listControls[i - 1].Left = 100;
            ifb.listControls[i - 1].Top = 140;

            //add a button
            ifb.addControl(new Button());
            i++;
            ifb.listControls[i - 1].Text = "Adauga";
            ifb.listControls[i - 1].Left = 200;
            ifb.listControls[i - 1].Top = 140;




            //field seriaci
            //add a label
            ifb.addControl(new Label());
            i++;
            ifb.listControls[i - 1].Text = "seriaci:";
            ifb.listControls[i - 1].Left = 10;
            ifb.listControls[i - 1].Top = 160;

            //add a textbox
            ifb.addControl(new TextBox());
            i++;
            ifb.listControls[i - 1].Text = "seria ci";
            ifb.listControls[i - 1].Left = 100;
            ifb.listControls[i - 1].Top = 160;

            //add a button
            ifb.addControl(new Button());
            i++;
            ifb.listControls[i - 1].Text = "Adauga";
            ifb.listControls[i - 1].Left = 200;
            ifb.listControls[i - 1].Top = 160;




            //field numarci
            //add a label
            ifb.addControl(new Label());
            i++;
            ifb.listControls[i - 1].Text = "numarci:";
            ifb.listControls[i - 1].Left = 10;
            ifb.listControls[i - 1].Top = 180;

            //add a textbox
            ifb.addControl(new TextBox());
            i++;
            ifb.listControls[i - 1].Text = "numar ci";
            ifb.listControls[i - 1].Left = 100;
            ifb.listControls[i - 1].Top = 180;

            //add a button
            ifb.addControl(new Button());
            i++;
            ifb.listControls[i - 1].Text = "Adauga";
            ifb.listControls[i - 1].Left = 200;
            ifb.listControls[i - 1].Top = 180;




            //field eliberatde
            //add a label
            ifb.addControl(new Label());
            i++;
            ifb.listControls[i - 1].Text = "eliberatde:";
            ifb.listControls[i - 1].Left = 10;
            ifb.listControls[i - 1].Top = 200;

            //add a textbox
            ifb.addControl(new TextBox());
            i++;
            ifb.listControls[i - 1].Text = "eliberatde";
            ifb.listControls[i - 1].Left = 100;
            ifb.listControls[i - 1].Top = 200;

            //add a button
            ifb.addControl(new Button());
            i++;
            ifb.listControls[i - 1].Text = "Adauga";
            ifb.listControls[i - 1].Left = 200;
            ifb.listControls[i - 1].Top = 200;




            //field cnp
            //add a label
            ifb.addControl(new Label());
            i++;
            ifb.listControls[i - 1].Text = "CNP:";
            ifb.listControls[i - 1].Left = 10;
            ifb.listControls[i - 1].Top = 220;

            //add a textbox
            ifb.addControl(new TextBox());
            i++;
            ifb.listControls[i - 1].Text = "cnp";
            ifb.listControls[i - 1].Left = 100;
            ifb.listControls[i - 1].Top = 220;

            //add a button
            ifb.addControl(new Button());
            i++;
            ifb.listControls[i - 1].Text = "Adauga";
            ifb.listControls[i - 1].Left = 200;
            ifb.listControls[i - 1].Top = 220;



            //form submit
            //add a label
            ifb.addControl(new Label());
            i++;
            ifb.listControls[i - 1].Text = "save datas:";
            ifb.listControls[i - 1].Left = 100;
            ifb.listControls[i - 1].Top = 320;

            //add a button
            ifb.addControl(new Button());
            i++;
            ifb.listControls[i - 1].Text = "Save";
            ifb.listControls[i - 1].Left = 200;
            ifb.listControls[i - 1].Top = 320;
            ifb.listControls[i - 1].Click += new System.EventHandler(this.saveDatas);

            //show controls
            ifb.showControls();


        }
        */
    }
}
