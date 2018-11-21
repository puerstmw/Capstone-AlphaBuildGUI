using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_AlphaBuild
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartupInitialize();

            BGW_LifecycleDemo.WorkerSupportsCancellation = true;

            System.Windows.Forms.Timer UPtimer = new System.Windows.Forms.Timer();
            UPtimer.Interval = (1000);  //Every sec
            UPtimer.Tick += new EventHandler(Timer_FormUpdate_Tick);
            UPtimer.Start();
        }

        private void StartupInitialize()
        {            
            P_Node1.Hide();
            P_Node2.Hide();
            P_Node3.Hide();
            P_Node4.Hide();
            P_Node5.Hide();
        }
      
        //Global Variables         
        public List<int> BlackList = new List<int>();

        // Form Management         

        public void FillNode1Slot(NM.Node node)
        {
            TB_NodeName1.Text = node.NodeName;
            List<DataType> LocalDataTypes = node.DataTypes;
            TB_DataTypes1.Text = "Type: ";
            for (int i = 0; i < LocalDataTypes.Count(); i++)
            {
                TB_DataTypes1.Text += LocalDataTypes[i].ToString();
            }
            TB_Limits1.Text = "Limits: " + node.LowLimit.ToString() + " < x < " + node.HighLimit.ToString();
            LB_Node1SN.Text = node.SN.ToString();
            if (node.InactiveFlag == true) RTB_Node1ColorStatus.BackColor = Color.Maroon;
            else RTB_Node1ColorStatus.BackColor = Color.Lime;
            LB_N1Battery.Text = node.BatteryLevel.ToString();
            P_Node1.Show();
        }
        public void FillNode2Slot(NM.Node node)
        {
            TB_NodeName2.Text = node.NodeName;
            List<DataType> LocalDataTypes = node.DataTypes;
            TB_DataTypes2.Text = "Type: ";
            for (int i = 0; i < LocalDataTypes.Count(); i++)
            {
                TB_DataTypes2.Text += LocalDataTypes[i].ToString();
            }
            TB_Limits2.Text = "Limits: " + node.LowLimit.ToString() + " < x < " + node.HighLimit.ToString();
            LB_Node2SN.Text = node.SN.ToString();
            if (node.InactiveFlag == true) RTB_Node2ColorStatus.BackColor = Color.Maroon;
            else RTB_Node2ColorStatus.BackColor = Color.Lime;
            LB_N2Battery.Text = node.BatteryLevel.ToString();
            P_Node2.Show();
        }

        public void FillNode3Slot(NM.Node node)
        {
            TB_NodeName3.Text = node.NodeName;
            List<DataType> LocalDataTypes = node.DataTypes;
            TB_DataTypes3.Text = "Type: ";
            for (int i = 0; i < LocalDataTypes.Count(); i++)
            {
                TB_DataTypes3.Text += LocalDataTypes[i].ToString();
            }
            TB_Limits3.Text = "Limits: " + node.LowLimit.ToString() + " < x < " + node.HighLimit.ToString();
            LB_Node3SN.Text = node.SN.ToString();
            if (node.InactiveFlag == true) RTB_Node3ColorStatus.BackColor = Color.Maroon;
            else RTB_Node3ColorStatus.BackColor = Color.Lime;
            LB_N3Battery.Text = node.BatteryLevel.ToString();
            P_Node3.Show();
        }

        public void FillNode4Slot(NM.Node node)
        {
            TB_NodeName4.Text = node.NodeName;
            List<DataType> LocalDataTypes = node.DataTypes;
            TB_DataTypes4.Text = "Type: ";
            for (int i = 0; i < LocalDataTypes.Count(); i++)
            {
                TB_DataTypes4.Text += LocalDataTypes[i].ToString();
            }
            TB_Limits4.Text = "Limits: " + node.LowLimit.ToString() + " < x < " + node.HighLimit.ToString();
            LB_Node4SN.Text = node.SN.ToString();
            if (node.InactiveFlag == true) RTB_Node4ColorStatus.BackColor = Color.Maroon;
            else RTB_Node4ColorStatus.BackColor = Color.Lime;
            LB_N4Battery.Text = node.BatteryLevel.ToString();
            P_Node4.Show();
        }

        public void FillNode5Slot(NM.Node node)
        {
            TB_NodeName5.Text = node.NodeName;
            List<DataType> LocalDataTypes = node.DataTypes;
            TB_DataTypes5.Text = "Type: ";
            for (int i = 0; i < LocalDataTypes.Count(); i++)
            {
                TB_DataTypes5.Text += LocalDataTypes[i].ToString();
            }
            TB_Limits5.Text = "Limits: " + node.LowLimit.ToString() + " < x < " + node.HighLimit.ToString();
            LB_Node5SN.Text = node.SN.ToString();
            if (node.InactiveFlag == true) RTB_Node5ColorStatus.BackColor = Color.Maroon;
            else RTB_Node5ColorStatus.BackColor = Color.Lime;
            LB_N5Battery.Text = node.BatteryLevel.ToString();
            P_Node5.Show();
        }

        public void CleanNodeManagementPage()
        {
            P_Node1.Hide();
            P_Node2.Hide();
            P_Node3.Hide();
            P_Node4.Hide();
            P_Node5.Hide();

            switch (NM.NodeDict.Count)
            {
                case 0:
                    P_Node1.Hide();
                    P_Node2.Hide();
                    P_Node3.Hide();
                    P_Node4.Hide();
                    P_Node5.Hide();
                    TB_NodeName1.Text = string.Empty;
                    TB_DataTypes1.Text = "Type: ";
                    TB_Limits1.Text = "Limits: Undefined";
                    LB_Node1SN.Text = string.Empty;
                    CB_SelectNode1.Checked = false;

                    TB_NodeName2.Text = string.Empty;
                    TB_DataTypes2.Text = "Type: ";
                    TB_Limits2.Text = "Limits: Undefined";
                    LB_Node2SN.Text = string.Empty;
                    CB_SelectNode2.Checked = false;

                    TB_NodeName3.Text = string.Empty;
                    TB_DataTypes3.Text = "Type: ";
                    TB_Limits3.Text = "Limits: Undefined";
                    LB_Node3SN.Text = string.Empty;
                    CB_SelectNode3.Checked = false;

                    TB_NodeName4.Text = string.Empty;
                    TB_DataTypes4.Text = "Type: ";
                    TB_Limits4.Text = "Limits: Undefined";
                    LB_Node4SN.Text = string.Empty;
                    CB_SelectNode4.Checked = false;

                    TB_NodeName5.Text = string.Empty;
                    TB_DataTypes5.Text = "Type: ";
                    TB_Limits5.Text = "Limits: Undefined";
                    LB_Node5SN.Text = string.Empty;
                    CB_SelectNode5.Checked = false;
                    break;
                case 1:
                    P_Node2.Hide();
                    P_Node3.Hide();
                    P_Node4.Hide();
                    P_Node5.Hide();

                    CB_SelectNode1.Checked = false;

                    TB_NodeName2.Text = string.Empty;
                    TB_DataTypes2.Text = "Type: ";
                    TB_Limits2.Text = "Limits: Undefined";
                    LB_Node2SN.Text = string.Empty;
                    CB_SelectNode2.Checked = false;

                    TB_NodeName3.Text = string.Empty;
                    TB_DataTypes3.Text = "Type: ";
                    TB_Limits3.Text = "Limits: Undefined";
                    LB_Node3SN.Text = string.Empty;
                    CB_SelectNode3.Checked = false;

                    TB_NodeName4.Text = string.Empty;
                    TB_DataTypes4.Text = "Type: ";
                    TB_Limits4.Text = "Limits: Undefined";
                    LB_Node4SN.Text = string.Empty;
                    CB_SelectNode4.Checked = false;

                    TB_NodeName5.Text = string.Empty;
                    TB_DataTypes5.Text = "Type: ";
                    TB_Limits5.Text = "Limits: Undefined";
                    LB_Node5SN.Text = string.Empty;
                    CB_SelectNode5.Checked = false;
                    break;
                case 2:
                    P_Node3.Hide();
                    P_Node4.Hide();
                    P_Node5.Hide();

                    CB_SelectNode1.Checked = false;
                    CB_SelectNode2.Checked = false;

                    TB_NodeName3.Text = string.Empty;
                    TB_DataTypes3.Text = "Type: ";
                    TB_Limits3.Text = "Limits: Undefined";
                    LB_Node3SN.Text = string.Empty;
                    CB_SelectNode3.Checked = false;

                    TB_NodeName4.Text = string.Empty;
                    TB_DataTypes4.Text = "Type: ";
                    TB_Limits4.Text = "Limits: Undefined";
                    LB_Node4SN.Text = string.Empty;
                    CB_SelectNode4.Checked = false;

                    TB_NodeName5.Text = string.Empty;
                    TB_DataTypes5.Text = "Type: ";
                    TB_Limits5.Text = "Limits: Undefined";
                    LB_Node5SN.Text = string.Empty;
                    CB_SelectNode5.Checked = false;
                    break;
                case 3:
                    P_Node4.Hide();
                    P_Node5.Hide();

                    CB_SelectNode1.Checked = false;
                    CB_SelectNode2.Checked = false;
                    CB_SelectNode3.Checked = false;

                    TB_NodeName4.Text = string.Empty;
                    TB_DataTypes4.Text = "Type: ";
                    TB_Limits4.Text = "Limits: Undefined";
                    LB_Node4SN.Text = string.Empty;
                    CB_SelectNode4.Checked = false;

                    TB_NodeName5.Text = string.Empty;
                    TB_DataTypes5.Text = "Type: ";
                    TB_Limits5.Text = "Limits: Undefined";
                    LB_Node5SN.Text = string.Empty;
                    CB_SelectNode5.Checked = false;
                    break;
                case 4:
                    P_Node5.Hide();

                    CB_SelectNode1.Checked = false;
                    CB_SelectNode2.Checked = false;
                    CB_SelectNode3.Checked = false;
                    CB_SelectNode4.Checked = false;

                    TB_NodeName5.Text = string.Empty;
                    TB_DataTypes5.Text = "Type: ";
                    TB_Limits5.Text = "Limits: Undefined";
                    LB_Node5SN.Text = string.Empty;
                    CB_SelectNode5.Checked = false;
                    break;
                case 5:
                    break;
                default:
                    break;
            }            
        }

        public void UpdateNodeManagementPage()
        {
            int count = 0;
            foreach (KeyValuePair<int, NM.Node> node in NM.NodeDict)
            {
                switch (count)
                {
                    case 0:
                        FillNode1Slot(NM.NodeDict[node.Key]);
                        count++;
                        break;
                    case 1:
                        FillNode2Slot(NM.NodeDict[node.Key]);
                        count++;
                        break;
                    case 2:
                        FillNode3Slot(NM.NodeDict[node.Key]);
                        count++;
                        break;
                    case 3:
                        FillNode4Slot(NM.NodeDict[node.Key]);
                        count++;
                        break;
                    case 4:
                        FillNode5Slot(NM.NodeDict[node.Key]);
                        count++;
                        break;
                    default:
                        //Error Message
                        break;
                }
            }
        }

        

        private void BT_EditN1Name_Click(object sender, EventArgs e)
        {
            if (BT_EditN1Name.Text == "Rename")
            {
                TB_NodeName1.ReadOnly = false;
                TB_NodeName1.SelectAll();
                BT_EditN1Name.Text = "Save";
            }
            else
            {
                TB_NodeName1.ReadOnly = true;
                //NM.NodeDict[0].NodeName = TB_NodeName1.Text;
                BT_EditN1Name.Text = "Rename";
            }            
        }

        private void BT_EditParams_Click(object sender, EventArgs e)
        {
            new Parameter_Form().Show();
        }

        private void BT_AddNode_Click(object sender, EventArgs e)
        {            
            AddNodePopup addNodePopup = new AddNodePopup();
            addNodePopup.ShowDialog();

            UpdateNodeManagementPage();                    
             
            TB_StatusNode1.Text = AddNodePopup.UserInputParameter1;

            //FillNode1Slot(node1);
        }

        private void CB_SelectNode1_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_SelectNode1.Checked) BlackList.Add(Convert.ToInt32(LB_Node1SN.Text));
            else
            {
                try { BlackList.Remove(Convert.ToInt32(LB_Node1SN.Text)); }
                catch { }
            }
        }

        private void CB_SelectNode2_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_SelectNode2.Checked) BlackList.Add(Convert.ToInt32(LB_Node2SN.Text));
            else
            {
                try { BlackList.Remove(Convert.ToInt32(LB_Node2SN.Text)); }
                catch { }
            }
        }

        private void CB_SelectNode3_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_SelectNode3.Checked) BlackList.Add(Convert.ToInt32(LB_Node3SN.Text));
            else
            {
                try { BlackList.Remove(Convert.ToInt32(LB_Node3SN.Text)); }
                catch { }
            }  
        }

        private void CB_SelectNode4_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_SelectNode4.Checked) BlackList.Add(Convert.ToInt32(LB_Node4SN.Text));
            else
            {
                try { BlackList.Remove(Convert.ToInt32(LB_Node4SN.Text)); }
                catch { }
            }
        }

        private void CB_SelectNode5_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_SelectNode5.Checked) BlackList.Add(Convert.ToInt32(LB_Node5SN.Text));
            else
            {
                try { BlackList.Remove(Convert.ToInt32(LB_Node5SN.Text)); }
                catch { }
            }
        }

        private void BT_RemoveNodes_Click(object sender, EventArgs e)
        {                                    
            foreach (int SN in BlackList) { NM.deleteNode(SN); }
            CleanNodeManagementPage();
            UpdateNodeManagementPage();
        }

        private void BT_ShowNodeKeys_Click(object sender, EventArgs e)
        {           
            System.Windows.Forms.MessageBox.Show("Number of nodes: " + NM.NodeDict.Count());
        }

        private void BT_ReceiveData_Click(object sender, EventArgs e)
        {            
            CM.DisplayData(CM.ReceiveData().ToList(), RTB_Data);
        }

        private void BT_DecodeData_Click(object sender, EventArgs e)
        {
            Testing.ProvideRandDataSet(RTB_DecodedData);
        }

        private void Timer_FormUpdate_Tick(object sender, EventArgs e)
        {
            UpdateNodeManagementPage();
        }

        private void BGW_LifecycleDemo_DoWork(object sender, DoWorkEventArgs e)
        {           
            //main actions
            while (true)
            {
                foreach (KeyValuePair<int, NM.Node> node in NM.NodeDict)
                {
                    if (NM.NodeDict[node.Key].BatteryLevel != 0) NM.NodeDict[node.Key].BatteryLevel--;
                    else NM.NodeDict[node.Key].InactiveFlag = true;
                }

                if (BGW_LifecycleDemo.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }

                //pause
                Thread.Sleep(750);
            }            
        }

        private void BT_StartSim_Click(object sender, EventArgs e)
        {
            if (BGW_LifecycleDemo.IsBusy != true)
            {
                // Start the asynchronous operation.
                BGW_LifecycleDemo.RunWorkerAsync();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Closing conditions
        }

        private void BT_StopSim_Click(object sender, EventArgs e)
        {
            if (BGW_LifecycleDemo.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                BGW_LifecycleDemo.CancelAsync();
            }
        }

        //private void BT_SimDataTime_Click(object sender, EventArgs e)
        //{
            
        //}

        //Testing
        private void BT_SimDataTime_Click_1(object sender, EventArgs e)
        {
            RTB_DataSetViewer.Text = Testing.DecodeData();
        }

        //Testing
        private void BT_SendtoN1_Click(object sender, EventArgs e)
        {
            RTB_DataSetViewer.Text = Testing.DecodeData();

            try
            {
                NM.NodeDict[0].Data.Add(Testing.ProvideDataTime())
            }
            catch { }
        }
    }
}
