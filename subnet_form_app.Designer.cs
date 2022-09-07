namespace SubnetCalculator
{
    partial class subnet_form_app
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subnet_form_app));
            this.currNetAddrOctet1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currNetAddrOctet2 = new System.Windows.Forms.TextBox();
            this.currNetAddrOctet3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.currNetAddrOctet4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currNetAddrSubnet = new System.Windows.Forms.TextBox();
            this.setNetworkAddr = new System.Windows.Forms.Button();
            this.AddedSubnets = new System.Windows.Forms.ListBox();
            this.AddSubnetButton = new System.Windows.Forms.Button();
            this.addSubnetTextbox = new System.Windows.Forms.TextBox();
            this.generateSubnets = new System.Windows.Forms.Button();
            this.CreatedSubnets = new System.Windows.Forms.ListBox();
            this.clearAddedSubnets = new System.Windows.Forms.Button();
            this.selectedSubnetPanel = new System.Windows.Forms.Panel();
            this.copyButton = new System.Windows.Forms.Button();
            this.RequestInfo = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.selectedSubnetListbox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.selectedSubnetPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // currNetAddrOctet1
            // 
            this.currNetAddrOctet1.Location = new System.Drawing.Point(12, 39);
            this.currNetAddrOctet1.MaxLength = 3;
            this.currNetAddrOctet1.Name = "currNetAddrOctet1";
            this.currNetAddrOctet1.Size = new System.Drawing.Size(41, 20);
            this.currNetAddrOctet1.TabIndex = 0;
            this.currNetAddrOctet1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateNumberKeypress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Supplied Network Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = ".";
            // 
            // currNetAddrOctet2
            // 
            this.currNetAddrOctet2.Location = new System.Drawing.Point(67, 39);
            this.currNetAddrOctet2.MaxLength = 3;
            this.currNetAddrOctet2.Name = "currNetAddrOctet2";
            this.currNetAddrOctet2.Size = new System.Drawing.Size(41, 20);
            this.currNetAddrOctet2.TabIndex = 7;
            this.currNetAddrOctet2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateNumberKeypress);
            // 
            // currNetAddrOctet3
            // 
            this.currNetAddrOctet3.Location = new System.Drawing.Point(120, 39);
            this.currNetAddrOctet3.MaxLength = 3;
            this.currNetAddrOctet3.Name = "currNetAddrOctet3";
            this.currNetAddrOctet3.Size = new System.Drawing.Size(41, 20);
            this.currNetAddrOctet3.TabIndex = 9;
            this.currNetAddrOctet3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateNumberKeypress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = ".";
            // 
            // currNetAddrOctet4
            // 
            this.currNetAddrOctet4.Location = new System.Drawing.Point(176, 39);
            this.currNetAddrOctet4.MaxLength = 3;
            this.currNetAddrOctet4.Name = "currNetAddrOctet4";
            this.currNetAddrOctet4.Size = new System.Drawing.Size(41, 20);
            this.currNetAddrOctet4.TabIndex = 11;
            this.currNetAddrOctet4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateNumberKeypress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "/";
            // 
            // currNetAddrSubnet
            // 
            this.currNetAddrSubnet.Location = new System.Drawing.Point(247, 39);
            this.currNetAddrSubnet.MaxLength = 3;
            this.currNetAddrSubnet.Name = "currNetAddrSubnet";
            this.currNetAddrSubnet.Size = new System.Drawing.Size(41, 20);
            this.currNetAddrSubnet.TabIndex = 13;
            this.currNetAddrSubnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateNumberKeypress);
            // 
            // setNetworkAddr
            // 
            this.setNetworkAddr.Location = new System.Drawing.Point(298, 38);
            this.setNetworkAddr.Name = "setNetworkAddr";
            this.setNetworkAddr.Size = new System.Drawing.Size(75, 23);
            this.setNetworkAddr.TabIndex = 14;
            this.setNetworkAddr.Text = "Set";
            this.setNetworkAddr.UseVisualStyleBackColor = true;
            this.setNetworkAddr.Click += new System.EventHandler(this.setNetworkAddr_Click);
            // 
            // AddedSubnets
            // 
            this.AddedSubnets.FormattingEnabled = true;
            this.AddedSubnets.Location = new System.Drawing.Point(12, 142);
            this.AddedSubnets.Name = "AddedSubnets";
            this.AddedSubnets.Size = new System.Drawing.Size(120, 186);
            this.AddedSubnets.TabIndex = 15;
            // 
            // AddSubnetButton
            // 
            this.AddSubnetButton.Location = new System.Drawing.Point(59, 113);
            this.AddSubnetButton.Name = "AddSubnetButton";
            this.AddSubnetButton.Size = new System.Drawing.Size(75, 23);
            this.AddSubnetButton.TabIndex = 16;
            this.AddSubnetButton.Text = "Add Subnet";
            this.AddSubnetButton.UseVisualStyleBackColor = true;
            this.AddSubnetButton.Click += new System.EventHandler(this.AddSubnetButton_Click);
            // 
            // addSubnetTextbox
            // 
            this.addSubnetTextbox.Location = new System.Drawing.Point(12, 115);
            this.addSubnetTextbox.MaxLength = 3;
            this.addSubnetTextbox.Name = "addSubnetTextbox";
            this.addSubnetTextbox.Size = new System.Drawing.Size(41, 20);
            this.addSubnetTextbox.TabIndex = 17;
            this.addSubnetTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateNumberKeypress);
            // 
            // generateSubnets
            // 
            this.generateSubnets.Location = new System.Drawing.Point(34, 334);
            this.generateSubnets.Name = "generateSubnets";
            this.generateSubnets.Size = new System.Drawing.Size(75, 23);
            this.generateSubnets.TabIndex = 18;
            this.generateSubnets.Text = "Generate";
            this.generateSubnets.UseVisualStyleBackColor = true;
            this.generateSubnets.Visible = false;
            this.generateSubnets.Click += new System.EventHandler(this.generateSubnets_Click);
            // 
            // CreatedSubnets
            // 
            this.CreatedSubnets.FormattingEnabled = true;
            this.CreatedSubnets.Location = new System.Drawing.Point(158, 142);
            this.CreatedSubnets.Name = "CreatedSubnets";
            this.CreatedSubnets.Size = new System.Drawing.Size(120, 186);
            this.CreatedSubnets.TabIndex = 19;
            this.CreatedSubnets.Visible = false;
            this.CreatedSubnets.Click += new System.EventHandler(this.CreatedSubnets_Click);
            // 
            // clearAddedSubnets
            // 
            this.clearAddedSubnets.Location = new System.Drawing.Point(34, 363);
            this.clearAddedSubnets.Name = "clearAddedSubnets";
            this.clearAddedSubnets.Size = new System.Drawing.Size(75, 23);
            this.clearAddedSubnets.TabIndex = 20;
            this.clearAddedSubnets.Text = "Clear";
            this.clearAddedSubnets.UseVisualStyleBackColor = true;
            this.clearAddedSubnets.Visible = false;
            this.clearAddedSubnets.Click += new System.EventHandler(this.clearAddedSubnets_Click);
            // 
            // selectedSubnetPanel
            // 
            this.selectedSubnetPanel.BackColor = System.Drawing.SystemColors.Control;
            this.selectedSubnetPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedSubnetPanel.Controls.Add(this.copyButton);
            this.selectedSubnetPanel.Controls.Add(this.RequestInfo);
            this.selectedSubnetPanel.Controls.Add(this.label7);
            this.selectedSubnetPanel.Controls.Add(this.selectedSubnetListbox);
            this.selectedSubnetPanel.Controls.Add(this.label6);
            this.selectedSubnetPanel.Location = new System.Drawing.Point(298, 142);
            this.selectedSubnetPanel.Name = "selectedSubnetPanel";
            this.selectedSubnetPanel.Size = new System.Drawing.Size(200, 215);
            this.selectedSubnetPanel.TabIndex = 21;
            this.selectedSubnetPanel.Visible = false;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(57, 187);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 4;
            this.copyButton.Text = "Copy Data";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // RequestInfo
            // 
            this.RequestInfo.FormattingEnabled = true;
            this.RequestInfo.Location = new System.Drawing.Point(4, 138);
            this.RequestInfo.Name = "RequestInfo";
            this.RequestInfo.Size = new System.Drawing.Size(191, 43);
            this.RequestInfo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Request Info";
            // 
            // selectedSubnetListbox
            // 
            this.selectedSubnetListbox.FormattingEnabled = true;
            this.selectedSubnetListbox.Location = new System.Drawing.Point(4, 28);
            this.selectedSubnetListbox.Name = "selectedSubnetListbox";
            this.selectedSubnetListbox.Size = new System.Drawing.Size(191, 82);
            this.selectedSubnetListbox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Selected Subnet Details";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.linkLabel1.Location = new System.Drawing.Point(452, 428);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 13);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Created by Dans";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // subnet_form_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.selectedSubnetPanel);
            this.Controls.Add(this.clearAddedSubnets);
            this.Controls.Add(this.CreatedSubnets);
            this.Controls.Add(this.generateSubnets);
            this.Controls.Add(this.addSubnetTextbox);
            this.Controls.Add(this.AddSubnetButton);
            this.Controls.Add(this.AddedSubnets);
            this.Controls.Add(this.setNetworkAddr);
            this.Controls.Add(this.currNetAddrSubnet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.currNetAddrOctet4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.currNetAddrOctet3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currNetAddrOctet2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currNetAddrOctet1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "subnet_form_app";
            this.Text = "Subnet Calculator";
            this.selectedSubnetPanel.ResumeLayout(false);
            this.selectedSubnetPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox currNetAddrOctet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox currNetAddrOctet2;
        private System.Windows.Forms.TextBox currNetAddrOctet3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox currNetAddrOctet4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox currNetAddrSubnet;
        private System.Windows.Forms.Button setNetworkAddr;
        private System.Windows.Forms.ListBox AddedSubnets;
        private System.Windows.Forms.Button AddSubnetButton;
        private System.Windows.Forms.TextBox addSubnetTextbox;
        private System.Windows.Forms.Button generateSubnets;
        private System.Windows.Forms.ListBox CreatedSubnets;
        private System.Windows.Forms.Button clearAddedSubnets;
        private System.Windows.Forms.Panel selectedSubnetPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox selectedSubnetListbox;
        private System.Windows.Forms.ListBox RequestInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

