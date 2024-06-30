
//Project by Nicholas J. Hale, class C# - ITCS 1250, MCC, Project 2//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            //Declared Variables //
            decimal RegistrationFee = 0.0m;
            decimal LodgingFee = 0.0m;
            int Days = 0;

            //Method tells, that if there is any value selected in WorkshopListBox, proceed with the next method//
            //If above fails, go to else//
            if (WorkshopListBox.SelectedIndex != -1)
            {

                //Assigns values to the variables declared before for each of the cases  //
                switch (WorkshopListBox.SelectedIndex)
                {
                    case 0:

                        Days = 3;
                        RegistrationFee = 1000;
                        break;

                    case 1:

                        Days = 3;
                        RegistrationFee = 800;
                        break;

                    case 2:

                        Days = 3;
                        RegistrationFee = 1500;
                        break;

                    case 3:

                        Days = 5;
                        RegistrationFee = 1300;
                        break;

                    case 4:

                        Days = 1;
                        RegistrationFee = 500;
                        break;
                }
            }
            else
            {
               
                MessageBox.Show("Please make sure that you have selected a Workshop");
            }

            //Method tells that if there is any value selected in LocationListbox, to proceed with next method//
            //If above fails, go to else//
            if (LocationListbox.SelectedIndex != -1)
            {
                //This method assigns values to variables declared before for each of the cases//
                switch (LocationListbox.SelectedIndex)
                    {
                        case 0:

                            LodgingFee = 150;
                            break;

                        case 1:

                            LodgingFee = 225;
                            break;

                        case 2:

                            LodgingFee = 175;
                            break;

                        case 3:

                            LodgingFee = 300;
                            break;

                        case 4:

                            LodgingFee = 175;
                            break;

                        case 5:

                            LodgingFee = 150;
                            break;
                    }
            }
            else
            {
                //Method gives the customer a warning when select fails an item from the LocationListbox//
                MessageBox.Show("Please make sure that you have selected a Location");
            }

            //Shows different solutions in the related outputlabels//
            RegCostOutputLabel.Text = RegistrationFee.ToString("c");
            LodCostOutputLabel.Text = LodgingFee.ToString("c");
            TotalCostOutputLabel.Text = (RegistrationFee + (LodgingFee * Days)).ToString("c");
        }
        //Method clears the selection of the listboxes made, and also clears outputlabels//
        private void ClearButton_Click(object sender, EventArgs e)
        {
            RegCostOutputLabel.Text = "";
            LodCostOutputLabel.Text = "";
            TotalCostOutputLabel.Text = "";
            WorkshopListBox.ClearSelected();
            LocationListbox.ClearSelected();
        }
        //Method kills the application//
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
