using System;
using System.Linq;
using System.Windows.Forms;
using A01_winform.Models;
using A01_winform.Repository;

namespace A01_winform
{
    public partial class Form1 : Form
    {
        private ShapeRepository shapeRepository = new ShapeRepository();

        public Form1()
        {
            InitializeComponent();
            //listbox settings & defaults
            lstGreen.SelectionMode = SelectionMode.MultiExtended;
            lstRed.SelectionMode = SelectionMode.MultiExtended;
            lstOrange.SelectionMode = SelectionMode.MultiExtended;
            lstGreen.Sorted = true;
            lstOrange.Sorted = true;
            lstRed.Sorted = true;
            lstGreen.ValueMember = "Area";
            lstOrange.ValueMember = "Area";
            lstRed.ValueMember = "Area";
            lstGreen.DisplayMember = "Name" + "(" + "Area" + ")";
            lstOrange.DisplayMember = "Name" + "(" + "Area" + ")";
            lstRed.DisplayMember = "Name" + "(" + "Area" + ")";
            //labels default
            lblLargestGreenArea.Tag = "'Area'";
            lblLargestGreenShape.Tag = "'Name'";
            lblLargestRedArea.Tag = "'Area'";
            lblLargestRedShape.Tag = "'Name'";
            lblLargestOrangeArea.Tag = "'Area'";
            lblLargestOrangehape.Tag = "'Name'";
            lblLargestShape.Tag = "'Name'";
            lblLargestShapeArea.Tag = "'Area'";
            lblLargestTotalArea.Tag = "'Area'";
        }

        #region methods to instantiate objects and refresh screens

        /// <summary>
        /// logic to instantiate object, define color
        /// </summary>
        protected void SetObject()
        {
            switch (cmbSelectShape.SelectedItem.ToString())
            {
                case "Circle":
                    shapeRepository.AddShape(ShapeForm.Circle, txtbName.Text, Convert.ToDouble(txtbProp1.Text));
                    break;
                case "Square":
                    shapeRepository.AddShape(ShapeForm.Square, txtbName.Text, Convert.ToDouble(txtbProp1.Text));
                    break;
                case "Rectangle":
                    shapeRepository.AddShape(ShapeForm.Rectangle, txtbName.Text, Convert.ToDouble(txtbProp1.Text),
                        Convert.ToDouble(txtbProp2.Text));
                    break;
                case "Triangle":
                    shapeRepository.AddShape(ShapeForm.Triangle, txtbName.Text, Convert.ToDouble(txtbProp1.Text),
                        Convert.ToDouble(txtbProp2.Text));
                    break;
            }
            RefreshForm();
            RefreshLabels();
        }

        //Refresh listviews & clear all textboxes
        private void RefreshForm()
        {
            //lists
            lstGreen.Items.Clear();
            lstGreen.Items.AddRange(shapeRepository.Shapes.Where(x => x.Color == Color.Green).ToArray());
            lstRed.Items.Clear();
            lstRed.Items.AddRange(shapeRepository.Shapes.Where(x => x.Color == Color.Red).ToArray());
            lstOrange.Items.Clear();
            lstOrange.Items.AddRange(shapeRepository.Shapes.Where(x => x.Color == Color.Orange).ToArray());
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
        private void RefreshLabels()
        {
            lblLargestGreenArea.Refresh();
            lblLargestGreenShape.Refresh();
            lblLargestOrangeArea.Refresh();
            lblLargestOrangehape.Refresh();
            lblLargestRedArea.Refresh();
            lblLargestRedShape.Refresh();
            lblLargestShape.Refresh();
            lblLargestShapeArea.Refresh();
            lblLargestTotalArea.Refresh();
            UpdateLables();
        }

        #endregion

        #region input 
        /// <summary>
        /// ButtonControls from the inputgroupbox
        /// </summary>
        
        // reset after comboboxselection
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

            //visible after selection from combobox
            bool selected = (cmbSelectShape.SelectedItem.ToString() == "Rectangle" ||
                             cmbSelectShape.SelectedItem.ToString() == "Circle" ||
                             cmbSelectShape.SelectedItem.ToString() == "Triangle" ||
                             cmbSelectShape.SelectedItem.ToString() == "Square");

            if (selected)
            {
                lblName.Visible = true;
                txtbName.Visible = true;
                btnAddName.Visible = true;
            }
        }

        private void btnAddName_Click(object sender, System.EventArgs e)
        {
            //txtbName: look for Name duplicates
            bool duplicate = false;
            foreach (Shape shape in shapeRepository.Shapes)
            {
                if (shape.Name == txtbName.Text)
                    duplicate = true;
            }
            if (duplicate)
            {
                txtbName.Focus();
                txtbName.BorderStyle = BorderStyle.Fixed3D;
                txtbName.BackColor = System.Drawing.Color.Red;
                txtbName.SelectAll();
            }
            else
            {
                txtbName.BorderStyle = BorderStyle.None;
                txtbName.BackColor = System.Drawing.Color.White;
                //general UIcode
                //prop2 stays invisible (circle only has prop1 = radius) => see shape specific code
                //idem sides square
                txtbProp1.Visible = true;
                btnAddProp1.Visible = true;
                btnAddName.Visible = false;
                txtbName.Enabled = false;

                //shape specific code
                switch (cmbSelectShape.SelectedItem.ToString())
                {
                    case "Rectangle":
                        lblProp1.Text = "Heigth";
                        lblProp2.Text = "Width";
                        lblProp1.Visible = true;
                        lblProp2.Visible = true;
                        txtbProp2.Visible = true;
                        btnAddName.Visible = false;
                        break;
                    case "Circle":
                        lblProp1.Text = "Radius";
                        lblProp1.Visible = true;
                        btnAddName.Visible = false;
                        break;
                    case "Square":
                        lblProp1.Text = "Side";
                        lblProp1.Visible = true;
                        btnAddName.Visible = false;
                        break;
                    case "Triangle":
                        lblProp1.Text = "Heigth";
                        lblProp2.Text = "Basis";
                        lblProp1.Visible = true;
                        lblProp2.Visible = true;
                        txtbProp2.Visible = true;
                        btnAddName.Visible = false;
                        break;
                }
            }
        }

        private void btnAddProp1_Click(object sender, System.EventArgs e)
        {
            btnAddProp1.Visible = false;
            txtbProp1.Enabled = false;

            switch(cmbSelectShape.SelectedItem.ToString())
            {
                case "Rectangle":
                    btnAddProp2.Visible = true;
                    btnAddName.Visible = false;
                    break;
                case "Circle":
                    lblProp1.Text = "Radius";
                    lblProp1.Visible = true;
                    btnAddName.Visible = false;
                    //
                    SetObject();
                    break;
                case "Square":
                    lblProp1.Text = "Side";
                    lblProp1.Visible = true;
                    btnAddName.Visible = false;
                    //
                    SetObject();
                    break;
                case "Triangle":
                    txtbProp2.Visible = true;
                    btnAddProp2.Visible = true;
                    break;
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
            {
                shapeRepository.Shapes.RemoveAt(lstGreen.SelectedIndex);
                RefreshForm();
                UpdateLables();
            }
        }

        private void btnDeleteOrangeShape_Click(object sender, EventArgs e)
        {
            if (lstOrange.SelectedIndex == -1)
                MessageBox.Show("Please select an item from the listbox.");
            else
            {
                shapeRepository.Shapes.RemoveAt(lstOrange.SelectedIndex);
                RefreshForm();
                UpdateLables();
            }
        }

        private void btnDeleteRedShape_Click(object sender, EventArgs e)
        {
            if (lstRed.SelectedIndex == -1)
                MessageBox.Show("Please select an item from the listbox.");
            else
            {
                shapeRepository.Shapes.RemoveAt(lstRed.SelectedIndex);
                RefreshForm();
                UpdateLables();
            }
        }
        #endregion
        #region Output
        public void UpdateLables()
        {
            lblLargestGreenArea.Text =
                (shapeRepository.Shapes.Where(x => x.Color == Color.Green)
                    .OrderByDescending(x => x.Area)
                    .FirstOrDefault()?
                    .Area.ToString());
            lblLargestGreenShape.Text =
                (shapeRepository.Shapes.Where(x => x.Color == Color.Green)
                    .OrderByDescending(x => x.Area)
                    .FirstOrDefault()?.Name
                    .ToString());
            lblLargestOrangeArea.Text =
                (shapeRepository.Shapes.Where(x => x.Color == Color.Orange)
                    .OrderByDescending(x => x.Area)
                    .FirstOrDefault()?
                    .Area.ToString());
            lblLargestOrangehape.Text =
                (shapeRepository.Shapes.Where(x => x.Color == Color.Orange)
                    .OrderByDescending(x => x.Area)
                    .FirstOrDefault()?.Name
                    .ToString());
            lblLargestRedArea.Text =
                (shapeRepository.Shapes.Where(x => x.Color == Color.Red)
                    .OrderByDescending(x => x.Area)
                    .FirstOrDefault()?
                    .Area.ToString());
            lblLargestRedShape.Text =
                (shapeRepository.Shapes.Where(x => x.Color == Color.Red)
                    .OrderByDescending(x => x.Area)
                    .FirstOrDefault()?.Name
                    .ToString());
            lblLargestShape.Text = (shapeRepository.Shapes.OrderByDescending(x => x.Area).FirstOrDefault()?.Name.ToString());
            lblLargestShapeArea.Text = (shapeRepository.Shapes.OrderByDescending(x => x.Area).FirstOrDefault()?.Area.ToString());
            lblLargestTotalArea.Text = shapeRepository.Shapes?.Sum(x => x.Area).ToString();
        }
        #endregion
    }
}
