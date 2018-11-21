using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_AlphaBuild
{
    public partial class AddNodePopup : Form
    {
        public static string UserInputParameter1 = "User Input Parameter 1";

        public AddNodePopup()
        {
            InitializeComponent();
        }

        private void BT_AddThisNode_Click(object sender, EventArgs e)
        {
            //ObjectHandling.Node node1 = new ObjectHandling.Node("Node000004", 000004, 97, new List<DataType> { DataType.Temperature },
            //    new List<ErrorMsg> { ErrorMsg.TestError }, false, false, 10, 5);

            

            //UserInputParameter1 = "I've updated.";
            
            //this.Close();
        }

        private void BT_AddDynamicNode_Click(object sender, EventArgs e)
        {            
            if (NM.NodeDict.Count < 5)
            {
                Testing.SupplyUniqueNode();
            }
            else
            {
                //Max number of nodes error
            }

            this.Close();
        }
    }
}
