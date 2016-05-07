using System;
using System.Linq;
using System.Windows.Forms;
using A01_winform.Models;

namespace A01_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstGreen.DataSource = s1.GreenShapes;
            lstGreen.DisplayMember = "Name";
            lstOrange.DataSource = s1.OrangeShapes;
            lstOrange.DisplayMember = "Name";
            lstRed.DataSource = s1.RedShapes;
            lstRed.DisplayMember = "Name";
        }

        #region methods to instantiate objects and refresh screens
        Shapes s1 = new Shapes();
        
        /// <summary>
        /// logic to instantiate object, define color
        /// </summary>
        protected void SetObject()
        {  
            if (cmbSelectShape.SelectedItem == "Circle")
            {
                try
                {
                    Shape shape1 = new Circle(txtbName.Text, Convert.ToInt32(txtbProp1.Text));
                    s1.AddToList(shape1);
                    RefreshForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            if (cmbSelectShape.SelectedItem == "Rectangle")
            {
                try
                {
                    Shape shape1 = new Rectangle(txtbName.Text, Convert.ToInt32(txtbProp1.Text), Convert.ToInt32(txtbProp2.Text));
                    s1.AddToList(shape1);
                    RefreshForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            if (cmbSelectShape.SelectedItem == "Square")
            {
                try
                {
                    Shape shape1 = new Square(txtbName.Text, Convert.ToInt32(txtbProp1.Text));
                    s1.AddToList(shape1);
                    RefreshForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            else if(cmbSelectShape.SelectedItem == "Triangle")
            {
                try
                {
                    Shape shape1 = new Triangle(txtbName.Text, Convert.ToInt32(txtbProp1.Text), Convert.ToInt32(txtbProp2.Text));
                    s1.AddToList(shape1);
                    RefreshForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        //Refresh listviews & clear all textboxes
        private void RefreshForm()
        {
            //listviews
            lstGreen.Refresh();
            lstOrange.Refresh();
            lstRed.Refresh();
            //txtboxes
            cmbSelectShape.ResetText();
            txtbName.Clear();
            txtbProp1.Clear();
            txtbProp2.Clear();
            //default enabled
            txtbName.Enabled = true;
            txtbProp1.Enabled = true;
            txtbProp2.Enabled = true;
            //default visibility
            lblName.Visible = false;
            txtbName.Visible = false;
            btnAddName.Visible = false;
            lblProp1.Visible = false;
            txtbProp1.Visible = false;
            btnAddProp1.Visible = false;
            lblProp2.Visible = false;
            txtbProp2.Visible = false;
            btnAddProp2.Visible = false;
        }
        #endregion
        #region input 
        /// <summary>
        /// ButtonControls from the inputgroupbox
        /// </summary>
        private void cmbSelectShape_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //default visibility after selection
            lblName.Visible = false;
            txtbName.Visible = false;
            btnAddName.Visible = false;
            lblProp1.Visible = false;
            txtbProp1.Visible = false;
            btnAddProp1.Visible = false;
            lblProp2.Visible = false;
            txtbProp2.Visible = false;
            btnAddProp2.Visible = false;

            //visible after selection
            bool selected = false;
            if (cmbSelectShape.SelectedItem == "Rectangle" || cmbSelectShape.SelectedItem == "Circle" ||
                cmbSelectShape.SelectedItem == "Triangle" || cmbSelectShape.SelectedItem == "Square")
            {
                selected = true;
            }

            if (selected)
            {
                lblName.Visible = true;
                txtbName.Visible = true;
                btnAddName.Visible = true;
            }
        }

        private void btnAddName_Click(object sender, System.EventArgs e)
        {
            //general UIcode
            //prop2 stays invisible (circle only has prop1 = radius) => see shape specific code
            //idem sides square

            txtbProp1.Visible = true;
            btnAddProp1.Visible = true;
            btnAddName.Visible = false;
            txtbName.Enabled = false;

            //shape specific code
            if (cmbSelectShape.SelectedItem == "Rectangle")
            {
                //UI
                lblProp1.Text = "Heigth";
                lblProp2.Text = "Width";
                lblProp1.Visible = true;
                lblProp2.Visible = true;
                txtbProp2.Visible = true;
                btnAddName.Visible = false;
            }
            if (cmbSelectShape.SelectedItem == "Circle")
            {
                //UI
                lblProp1.Text = "Radius";
                lblProp1.Visible = true;
                btnAddName.Visible = false;
            }
            if (cmbSelectShape.SelectedItem == "Square")
            {
                //UI
                lblProp1.Text = "Side";
                lblProp1.Visible = true;
                btnAddName.Visible = false;
            }
            if (cmbSelectShape.SelectedItem == "Triangle")
            {
                //UI
                lblProp1.Text = "Heigth";
                lblProp2.Text = "Basis";
                lblProp1.Visible = true;
                lblProp2.Visible = true;
                txtbProp2.Visible = true;
                btnAddName.Visible = false;
            }
        }

        private void btnAddProp1_Click(object sender, System.EventArgs e)
        {
            btnAddProp1.Visible = false;
            txtbProp1.Enabled = false;

            if (cmbSelectShape.SelectedItem == "Rectangle")
            {
                btnAddProp2.Visible = true;
                btnAddName.Visible = false;
            }
            if (cmbSelectShape.SelectedItem == "Circle")
            {
                lblProp1.Text = "Radius";
                lblProp1.Visible = true;
                btnAddName.Visible = false;
                //
                SetObject();
            }
            if (cmbSelectShape.SelectedItem == "Square")
            {
                lblProp1.Text = "Side";
                lblProp1.Visible = true;
                btnAddName.Visible = false;
                //
                SetObject();
            }
            if (cmbSelectShape.SelectedItem == "Triangle")
            {
                txtbProp2.Visible = true;
                btnAddProp2.Visible = true;
            }
        }

        private void btnAddProp2_Click(object sender, EventArgs e)
        {
            btnAddProp2.Visible = false;
            txtbProp2.Enabled = false;
            //
            SetObject();
        }
        #endregion
        #region DeleteFromListButtons
        private void btnDeleteGreenShape_Click(object sender, EventArgs e)
        {
            if (lstGreen.SelectedIndex == -1)
                MessageBox.Show("Please select an item from the listbox.");
            else
                s1.GreenShapes.RemoveAt(lstGreen.SelectedIndex);
        }

        private void btnDeleteOrangeShape_Click(object sender, EventArgs e)
        {
            if(lstOrange.SelectedIndex == -1)
                MessageBox.Show("Please select an item from the listbox.");
            else
                s1.OrangeShapes.RemoveAt(lstOrange.SelectedIndex);
        }

        private void btnDeleteRedShape_Click(object sender, EventArgs e)
        {
            if (lstRed.SelectedIndex == -1)
                MessageBox.Show("Please select an item from the listbox.");
            else
                s1.RedShapes.RemoveAt(lstRed.SelectedIndex);
        }
        #endregion
        #region Output
        public void UpdateLables()
        {
            if (s1.GreenShapes.Count != null)
            {

            }
        }
        #endregion
    }
}
