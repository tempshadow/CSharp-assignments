using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateFlooringCosts
{

    /// <summary>
    /// This class is the parent mdi-form. It has multible event listeners for
    /// not only a toolstrip buttons, but for toolstip menu items also.
    /// Created by: Nigel Mansell
    /// Date: 4/16/17
    /// </summary>
    public partial class frmFloringCalc : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public frmFloringCalc()
        {
            InitializeComponent();
        }


        /// <summary>
        /// A toolstrip menu item that when clicked, displays the carpeting form.
        /// </summary>
        /// <param name="sender"> see system.object </param>
        /// <param name="e"> see system.EventArgs </param>
        private void carpetingCostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newForm = new frmCarpeting();
            newForm.MdiParent = this;
            newForm.Show();
        }

        /// <summary>
        /// A toolstrip menu item that when clicked, displays the hardwood form.
        /// </summary>
        /// <param name="sender"> see system.object </param>
        /// <param name="e"> see system.EventArgs </param>
        private void hardwoodCostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newForm = new frmHardwood();
            newForm.MdiParent = this;
            newForm.Show();
        }

        /// <summary>
        /// A toolstrip menu item that when clicked, closes the active child form.
        /// </summary>
        /// <param name="sender"> see system.object </param>
        /// <param name="e"> see system.EventArgs </param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeForm = this.ActiveMdiChild;
            if (activeForm != null)
                activeForm.Close();

        }

        /// <summary>
        /// A toolstrip menu item that when clicked, exits out of the entire
        /// application.
        /// </summary>
        /// <param name="sender"> see system.object </param>
        /// <param name="e"> see system.EventArgs </param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        /// <summary>
        /// A toolstrip menu item that when clicked, arranges all child forms
        /// into a cascade.
        /// </summary>
        /// <param name="sender"> see system.object </param>
        /// <param name="e"> see system.EventArgs </param>
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        /// <summary>
        /// A toolstrip menu item that when clicked, arranges all child forms
        /// Vertically.
        /// </summary>
        /// <param name="sender"> see System.object </param>
        /// <param name="e"> see system.EventArgs </param>
        private void virticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        /// <summary>
        /// A toolstrip menu item that when clicked, arranges all child forms
        /// horizontally.
        /// </summary>
        /// <param name="sender"> see system.object </param>
        /// <param name="e"> see system.EventArgs </param>
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        /// <summary>
        /// A toolstrip button that when clicked, displays the carpeting form.
        /// </summary>
        /// <param name="sender"> see system.object </param>
        /// <param name="e"> see system.EventArgs </param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            carpetingCostsToolStripMenuItem.PerformClick();
        }

        /// <summary>
        /// A toolstrip button that when clicked, displays the hardwood form.
        /// </summary>
        /// <param name="sender"> see system.object </param>
        /// <param name="e"> see system.EventArgs </param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            hardwoodCostsToolStripMenuItem.PerformClick();
        }
    }
}
