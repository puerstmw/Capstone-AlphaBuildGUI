namespace Capstone_AlphaBuild
{
    partial class AddNodePopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_AddThisNode = new System.Windows.Forms.Button();
            this.RTB_AddNodeInfo = new System.Windows.Forms.RichTextBox();
            this.BT_AddDynamicNode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_AddThisNode
            // 
            this.BT_AddThisNode.Location = new System.Drawing.Point(286, 294);
            this.BT_AddThisNode.Name = "BT_AddThisNode";
            this.BT_AddThisNode.Size = new System.Drawing.Size(191, 104);
            this.BT_AddThisNode.TabIndex = 0;
            this.BT_AddThisNode.Text = "Add This Node";
            this.BT_AddThisNode.UseVisualStyleBackColor = true;
            this.BT_AddThisNode.Click += new System.EventHandler(this.BT_AddThisNode_Click);
            // 
            // RTB_AddNodeInfo
            // 
            this.RTB_AddNodeInfo.Location = new System.Drawing.Point(210, 80);
            this.RTB_AddNodeInfo.Name = "RTB_AddNodeInfo";
            this.RTB_AddNodeInfo.Size = new System.Drawing.Size(350, 131);
            this.RTB_AddNodeInfo.TabIndex = 1;
            this.RTB_AddNodeInfo.Text = "This page is used to specify the connection parameters to a node you desire to ad" +
    "d to the network. Currently the protocols have not been established, so the butt" +
    "on below adds a Pseudo-Node";
            // 
            // BT_AddDynamicNode
            // 
            this.BT_AddDynamicNode.Location = new System.Drawing.Point(483, 294);
            this.BT_AddDynamicNode.Name = "BT_AddDynamicNode";
            this.BT_AddDynamicNode.Size = new System.Drawing.Size(191, 104);
            this.BT_AddDynamicNode.TabIndex = 2;
            this.BT_AddDynamicNode.Text = "Add This Node(Dynamic)";
            this.BT_AddDynamicNode.UseVisualStyleBackColor = true;
            this.BT_AddDynamicNode.Click += new System.EventHandler(this.BT_AddDynamicNode_Click);
            // 
            // AddNodePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_AddDynamicNode);
            this.Controls.Add(this.RTB_AddNodeInfo);
            this.Controls.Add(this.BT_AddThisNode);
            this.Name = "AddNodePopup";
            this.Text = "AddNodePopup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_AddThisNode;
        private System.Windows.Forms.RichTextBox RTB_AddNodeInfo;
        private System.Windows.Forms.Button BT_AddDynamicNode;
    }
}