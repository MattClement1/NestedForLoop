/*
*Created by: Matthew Clement
*Created on: 20-Oct-2015
*Created for: Unit #3-13
*This program uses a nested for loop to show unicode characters
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestedForLoop
{
    public partial class frmNestedForLoop : Form
    {
        public frmNestedForLoop()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            for (int number = 65; number <= 90; number++)
            {
                for (int numberTwo = 97; numberTwo <= 122; numberTwo++)
                {
                    this.lstCharactersList.Items.Add(Char.ConvertFromUtf32(number) + "->" + Char.ConvertFromUtf32(numberTwo));
                }
            }
        }
    }
}
