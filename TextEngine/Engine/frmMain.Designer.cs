namespace Engine
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblEn = new System.Windows.Forms.Label();
            this.lblFa = new System.Windows.Forms.Label();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSrchEn = new System.Windows.Forms.Button();
            this.btnSrchFa = new System.Windows.Forms.Button();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.txtFa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEn
            // 
            this.lblEn.AutoSize = true;
            this.lblEn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblEn.Location = new System.Drawing.Point(12, 51);
            this.lblEn.Name = "lblEn";
            this.lblEn.Size = new System.Drawing.Size(80, 13);
            this.lblEn.TabIndex = 23;
            this.lblEn.Text = "„⁄«œ· «‰ê·Ì”Ì";
            // 
            // lblFa
            // 
            this.lblFa.AutoSize = true;
            this.lblFa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFa.Location = new System.Drawing.Point(12, 19);
            this.lblFa.Name = "lblFa";
            this.lblFa.Size = new System.Drawing.Size(71, 13);
            this.lblFa.TabIndex = 22;
            this.lblFa.Text = "⁄»«—  ›«—”Ì";
            // 
            // dgw
            // 
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Location = new System.Drawing.Point(12, 132);
            this.dgw.Name = "dgw";
            this.dgw.ReadOnly = true;
            this.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgw.Size = new System.Drawing.Size(526, 256);
            this.dgw.TabIndex = 21;
            this.dgw.CurrentCellChanged += new System.EventHandler(this.dgw_CurrentCellChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.Location = new System.Drawing.Point(463, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "·€Ê";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.Location = new System.Drawing.Point(382, 103);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "œŒÌ—Â";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnErase
            // 
            this.btnErase.Enabled = false;
            this.btnErase.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnErase.Location = new System.Drawing.Point(174, 103);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(75, 23);
            this.btnErase.TabIndex = 18;
            this.btnErase.Text = "Õ–›";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEdit.Location = new System.Drawing.Point(93, 103);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "ÊÌ—«Ì‘";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNew.Location = new System.Drawing.Point(12, 103);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "ÃœÌœ";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSrchEn
            // 
            this.btnSrchEn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSrchEn.Location = new System.Drawing.Point(278, 74);
            this.btnSrchEn.Name = "btnSrchEn";
            this.btnSrchEn.Size = new System.Drawing.Size(260, 23);
            this.btnSrchEn.TabIndex = 15;
            this.btnSrchEn.Text = "Ã” ÃÊÌ «‰ê·Ì”Ì";
            this.btnSrchEn.UseVisualStyleBackColor = true;
            this.btnSrchEn.Click += new System.EventHandler(this.btnSrchEn_Click);
            // 
            // btnSrchFa
            // 
            this.btnSrchFa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSrchFa.Location = new System.Drawing.Point(12, 74);
            this.btnSrchFa.Name = "btnSrchFa";
            this.btnSrchFa.Size = new System.Drawing.Size(260, 23);
            this.btnSrchFa.TabIndex = 14;
            this.btnSrchFa.Text = "Ã” ÃÊÌ ›«—”Ì";
            this.btnSrchFa.UseVisualStyleBackColor = true;
            this.btnSrchFa.Click += new System.EventHandler(this.btnSrchFa_Click);
            // 
            // txtEn
            // 
            this.txtEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtEn.Location = new System.Drawing.Point(93, 44);
            this.txtEn.MaxLength = 255;
            this.txtEn.Name = "txtEn";
            this.txtEn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEn.Size = new System.Drawing.Size(445, 24);
            this.txtEn.TabIndex = 13;
            this.txtEn.TextChanged += new System.EventHandler(this.txtEn_TextChanged);
            // 
            // txtFa
            // 
            this.txtFa.Location = new System.Drawing.Point(93, 12);
            this.txtFa.MaxLength = 255;
            this.txtFa.Name = "txtFa";
            this.txtFa.Size = new System.Drawing.Size(445, 26);
            this.txtFa.TabIndex = 12;
            this.txtFa.TextChanged += new System.EventHandler(this.txtFa_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.lblEn);
            this.Controls.Add(this.lblFa);
            this.Controls.Add(this.dgw);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSrchEn);
            this.Controls.Add(this.btnSrchFa);
            this.Controls.Add(this.txtEn);
            this.Controls.Add(this.txtFa);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ace.of.zerosync";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEn;
        private System.Windows.Forms.Label lblFa;
        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSrchEn;
        private System.Windows.Forms.Button btnSrchFa;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.TextBox txtFa;
    }
}

