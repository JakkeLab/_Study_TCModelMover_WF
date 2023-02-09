namespace TCModelMover_WF
{
    partial class Form1
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
            this.bt_Connect = new System.Windows.Forms.Button();
            this.lb_Status = new System.Windows.Forms.Label();
            this.lb_statusHeader = new System.Windows.Forms.Label();
            this.tb_ActiveProject = new System.Windows.Forms.TextBox();
            this.lb_ActiveProj_header = new System.Windows.Forms.Label();
            this.bt_Disconnect = new System.Windows.Forms.Button();
            this.bt_GetActiveProj = new System.Windows.Forms.Button();
            this.bt_getModelName = new System.Windows.Forms.Button();
            this.lb_getModelName_Header = new System.Windows.Forms.Label();
            this.tb_getModelName = new System.Windows.Forms.TextBox();
            this.bt_MoveObj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_MoveX = new System.Windows.Forms.TextBox();
            this.tb_MoveY = new System.Windows.Forms.TextBox();
            this.tb_MoveZ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_MoveobjStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Connect
            // 
            this.bt_Connect.Location = new System.Drawing.Point(13, 10);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(89, 23);
            this.bt_Connect.TabIndex = 1;
            this.bt_Connect.Text = "Connect";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Location = new System.Drawing.Point(170, 15);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(82, 12);
            this.lb_Status.TabIndex = 2;
            this.lb_Status.Text = "Disconnected";
            // 
            // lb_statusHeader
            // 
            this.lb_statusHeader.AutoSize = true;
            this.lb_statusHeader.Location = new System.Drawing.Point(112, 15);
            this.lb_statusHeader.Name = "lb_statusHeader";
            this.lb_statusHeader.Size = new System.Drawing.Size(52, 12);
            this.lb_statusHeader.TabIndex = 3;
            this.lb_statusHeader.Text = "Status : ";
            // 
            // tb_ActiveProject
            // 
            this.tb_ActiveProject.Location = new System.Drawing.Point(122, 116);
            this.tb_ActiveProject.Name = "tb_ActiveProject";
            this.tb_ActiveProject.ReadOnly = true;
            this.tb_ActiveProject.Size = new System.Drawing.Size(130, 21);
            this.tb_ActiveProject.TabIndex = 4;
            // 
            // lb_ActiveProj_header
            // 
            this.lb_ActiveProj_header.AutoSize = true;
            this.lb_ActiveProj_header.Location = new System.Drawing.Point(12, 119);
            this.lb_ActiveProj_header.Name = "lb_ActiveProj_header";
            this.lb_ActiveProj_header.Size = new System.Drawing.Size(90, 12);
            this.lb_ActiveProj_header.TabIndex = 5;
            this.lb_ActiveProj_header.Text = "Active Project :";
            // 
            // bt_Disconnect
            // 
            this.bt_Disconnect.Location = new System.Drawing.Point(14, 39);
            this.bt_Disconnect.Name = "bt_Disconnect";
            this.bt_Disconnect.Size = new System.Drawing.Size(89, 23);
            this.bt_Disconnect.TabIndex = 6;
            this.bt_Disconnect.Text = "Disconnect";
            this.bt_Disconnect.UseVisualStyleBackColor = true;
            this.bt_Disconnect.Click += new System.EventHandler(this.bt_Disconnect_Click);
            // 
            // bt_GetActiveProj
            // 
            this.bt_GetActiveProj.Location = new System.Drawing.Point(13, 144);
            this.bt_GetActiveProj.Name = "bt_GetActiveProj";
            this.bt_GetActiveProj.Size = new System.Drawing.Size(89, 23);
            this.bt_GetActiveProj.TabIndex = 7;
            this.bt_GetActiveProj.Text = "Get Proj";
            this.bt_GetActiveProj.UseVisualStyleBackColor = true;
            this.bt_GetActiveProj.Click += new System.EventHandler(this.bt_GetActiveProj_Click);
            // 
            // bt_getModelName
            // 
            this.bt_getModelName.Location = new System.Drawing.Point(12, 215);
            this.bt_getModelName.Name = "bt_getModelName";
            this.bt_getModelName.Size = new System.Drawing.Size(89, 23);
            this.bt_getModelName.TabIndex = 10;
            this.bt_getModelName.Text = "ModelName";
            this.bt_getModelName.UseVisualStyleBackColor = true;
            this.bt_getModelName.Click += new System.EventHandler(this.bt_getModelName_Click);
            // 
            // lb_getModelName_Header
            // 
            this.lb_getModelName_Header.AutoSize = true;
            this.lb_getModelName_Header.Location = new System.Drawing.Point(11, 190);
            this.lb_getModelName_Header.Name = "lb_getModelName_Header";
            this.lb_getModelName_Header.Size = new System.Drawing.Size(105, 12);
            this.lb_getModelName_Header.TabIndex = 9;
            this.lb_getModelName_Header.Text = "Get ModelName :";
            // 
            // tb_getModelName
            // 
            this.tb_getModelName.Location = new System.Drawing.Point(122, 187);
            this.tb_getModelName.Name = "tb_getModelName";
            this.tb_getModelName.ReadOnly = true;
            this.tb_getModelName.Size = new System.Drawing.Size(129, 21);
            this.tb_getModelName.TabIndex = 8;
            // 
            // bt_MoveObj
            // 
            this.bt_MoveObj.Location = new System.Drawing.Point(12, 350);
            this.bt_MoveObj.Name = "bt_MoveObj";
            this.bt_MoveObj.Size = new System.Drawing.Size(89, 23);
            this.bt_MoveObj.TabIndex = 13;
            this.bt_MoveObj.Text = "Move Object";
            this.bt_MoveObj.UseVisualStyleBackColor = true;
            this.bt_MoveObj.Click += new System.EventHandler(this.bt_MoveObj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Move selected objects";
            // 
            // tb_MoveX
            // 
            this.tb_MoveX.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_MoveX.Location = new System.Drawing.Point(14, 287);
            this.tb_MoveX.Name = "tb_MoveX";
            this.tb_MoveX.Size = new System.Drawing.Size(45, 21);
            this.tb_MoveX.TabIndex = 11;
            this.tb_MoveX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_OnlyNum);
            // 
            // tb_MoveY
            // 
            this.tb_MoveY.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_MoveY.Location = new System.Drawing.Point(65, 287);
            this.tb_MoveY.Name = "tb_MoveY";
            this.tb_MoveY.Size = new System.Drawing.Size(45, 21);
            this.tb_MoveY.TabIndex = 14;
            this.tb_MoveY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_OnlyNum);
            // 
            // tb_MoveZ
            // 
            this.tb_MoveZ.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_MoveZ.Location = new System.Drawing.Point(116, 287);
            this.tb_MoveZ.Name = "tb_MoveZ";
            this.tb_MoveZ.Size = new System.Drawing.Size(45, 21);
            this.tb_MoveZ.TabIndex = 15;
            this.tb_MoveZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_OnlyNum);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "Z";
            // 
            // lb_MoveobjStatus
            // 
            this.lb_MoveobjStatus.AutoSize = true;
            this.lb_MoveobjStatus.Location = new System.Drawing.Point(14, 325);
            this.lb_MoveobjStatus.Name = "lb_MoveobjStatus";
            this.lb_MoveobjStatus.Size = new System.Drawing.Size(111, 12);
            this.lb_MoveobjStatus.TabIndex = 19;
            this.lb_MoveobjStatus.Text = "No object selected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_MoveobjStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_MoveZ);
            this.Controls.Add(this.tb_MoveY);
            this.Controls.Add(this.bt_MoveObj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_MoveX);
            this.Controls.Add(this.bt_getModelName);
            this.Controls.Add(this.lb_getModelName_Header);
            this.Controls.Add(this.tb_getModelName);
            this.Controls.Add(this.bt_GetActiveProj);
            this.Controls.Add(this.bt_Disconnect);
            this.Controls.Add(this.lb_ActiveProj_header);
            this.Controls.Add(this.tb_ActiveProject);
            this.Controls.Add(this.lb_statusHeader);
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.bt_Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Label lb_statusHeader;
        private System.Windows.Forms.TextBox tb_ActiveProject;
        private System.Windows.Forms.Label lb_ActiveProj_header;
        private System.Windows.Forms.Button bt_Disconnect;
        private System.Windows.Forms.Button bt_GetActiveProj;
        private System.Windows.Forms.Button bt_getModelName;
        private System.Windows.Forms.Label lb_getModelName_Header;
        private System.Windows.Forms.TextBox tb_getModelName;
        private System.Windows.Forms.Button bt_MoveObj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_MoveX;
        private System.Windows.Forms.TextBox tb_MoveY;
        private System.Windows.Forms.TextBox tb_MoveZ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_MoveobjStatus;
    }
}

