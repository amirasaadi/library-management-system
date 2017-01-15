namespace Library
{
    partial class lending_managment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lending_managment));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNationalKod = new System.Windows.Forms.MaskedTextBox();
            this.txtBookID = new System.Windows.Forms.MaskedTextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtNationalKod
            // 
            this.txtNationalKod.Location = new System.Drawing.Point(610, 49);
            this.txtNationalKod.Mask = "0000000000";
            this.txtNationalKod.Name = "txtNationalKod";
            this.txtNationalKod.Size = new System.Drawing.Size(100, 24);
            this.txtNationalKod.TabIndex = 1;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(467, 49);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(100, 24);
            this.txtBookID.TabIndex = 2;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(660, 19);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(50, 17);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "کد ملی کاربر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "کد کتاب";
            // 
            // txtLend
            // 
            this.txtLend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLend.Location = new System.Drawing.Point(372, 49);
            this.txtLend.Name = "txtLend";
            this.txtLend.Size = new System.Drawing.Size(75, 23);
            this.txtLend.TabIndex = 3;
            this.txtLend.Text = "امانت دادن";
            this.txtLend.UseVisualStyleBackColor = true;
            this.txtLend.Click += new System.EventHandler(this.txtLend_Click);
            // 
            // lending_managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 321);
            this.Controls.Add(this.txtLend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.txtNationalKod);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("IRNazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "lending_managment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدیریت امانات";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox txtNationalKod;
        private System.Windows.Forms.MaskedTextBox txtBookID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtLend;
    }
}