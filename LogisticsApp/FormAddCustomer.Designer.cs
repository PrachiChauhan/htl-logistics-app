namespace LogisticsApp
{
    partial class FormAddCustomer
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.Button();
            this.btnfinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(203, 9);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(436, 51);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "Customer Information";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(25, 84);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 106);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "NAME";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(24, 130);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(59, 13);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "ADDRESS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "PHONE No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "PERCENT";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(169, 76);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(147, 20);
            this.txtid.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(169, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(169, 123);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(147, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(169, 149);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(147, 20);
            this.txtPhone.TabIndex = 9;
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(169, 176);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(147, 20);
            this.txtPercent.TabIndex = 10;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(671, 496);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(140, 58);
            this.txtAdd.TabIndex = 11;
            this.txtAdd.Text = "ADD";
            this.txtAdd.UseVisualStyleBackColor = true;
            this.txtAdd.Click += new System.EventHandler(this.txtAdd_Click);
            // 
            // btnfinish
            // 
            this.btnfinish.Location = new System.Drawing.Point(499, 496);
            this.btnfinish.Name = "btnfinish";
            this.btnfinish.Size = new System.Drawing.Size(140, 58);
            this.btnfinish.TabIndex = 12;
            this.btnfinish.Text = "FINISH";
            this.btnfinish.UseVisualStyleBackColor = true;
            this.btnfinish.Click += new System.EventHandler(this.btnfinish_Click);
            // 
            // FormAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 587);
            this.Controls.Add(this.btnfinish);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblDisplay);
            this.Name = "FormAddCustomer";
            this.Text = "FormAddCustomer";
            this.Load += new System.EventHandler(this.FormAddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Button txtAdd;
        private System.Windows.Forms.Button btnfinish;
    }
}