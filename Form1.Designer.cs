namespace ReadKeyCode
{
    partial class frmReadKeyCode
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
            this.txtKeyCode = new System.Windows.Forms.TextBox();
            this.labKey = new System.Windows.Forms.Label();
            this.txtKeyData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeyValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeyPlus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKeyCode
            // 
            this.txtKeyCode.Location = new System.Drawing.Point(88, 47);
            this.txtKeyCode.Name = "txtKeyCode";
            this.txtKeyCode.ReadOnly = true;
            this.txtKeyCode.Size = new System.Drawing.Size(141, 20);
            this.txtKeyCode.TabIndex = 2;
            // 
            // labKey
            // 
            this.labKey.AutoSize = true;
            this.labKey.Location = new System.Drawing.Point(30, 50);
            this.labKey.Name = "labKey";
            this.labKey.Size = new System.Drawing.Size(50, 13);
            this.labKey.TabIndex = 1;
            this.labKey.Text = "KeyCode";
            // 
            // txtKeyData
            // 
            this.txtKeyData.Location = new System.Drawing.Point(88, 73);
            this.txtKeyData.Name = "txtKeyData";
            this.txtKeyData.ReadOnly = true;
            this.txtKeyData.Size = new System.Drawing.Size(141, 20);
            this.txtKeyData.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "KeyData";
            // 
            // txtKeyValue
            // 
            this.txtKeyValue.Location = new System.Drawing.Point(88, 99);
            this.txtKeyValue.Name = "txtKeyValue";
            this.txtKeyValue.ReadOnly = true;
            this.txtKeyValue.Size = new System.Drawing.Size(141, 20);
            this.txtKeyValue.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "KeyValue";
            // 
            // txtKeyPlus
            // 
            this.txtKeyPlus.Location = new System.Drawing.Point(88, 21);
            this.txtKeyPlus.Name = "txtKeyPlus";
            this.txtKeyPlus.ReadOnly = true;
            this.txtKeyPlus.Size = new System.Drawing.Size(141, 20);
            this.txtKeyPlus.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Key +";
            // 
            // frmReadKeyCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 156);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labKey);
            this.Controls.Add(this.txtKeyPlus);
            this.Controls.Add(this.txtKeyValue);
            this.Controls.Add(this.txtKeyData);
            this.Controls.Add(this.txtKeyCode);
            this.KeyPreview = true;
            this.Name = "frmReadKeyCode";
            this.Text = "ReadKeyCode";
            this.Load += new System.EventHandler(this.frmReadKeyCode_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmReadKeyCode_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeyCode;
        private System.Windows.Forms.Label labKey;
        private System.Windows.Forms.TextBox txtKeyData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKeyPlus;
        private System.Windows.Forms.Label label3;
    }
}

