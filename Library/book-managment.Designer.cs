namespace Library
{
    partial class book_managment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lnum = new System.Windows.Forms.Label();
            this.lsha = new System.Windows.Forms.Label();
            this.lsal = new System.Windows.Forms.Label();
            this.lpubli = new System.Windows.Forms.Label();
            this.lath = new System.Windows.Forms.Label();
            this.lnam = new System.Windows.Forms.Label();
            this.lkod = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtshabak = new System.Windows.Forms.TextBox();
            this.txtbooktitle = new System.Windows.Forms.TextBox();
            this.txtbookcategory = new System.Windows.Forms.TextBox();
            this.txtpublisher = new System.Windows.Forms.TextBox();
            this.txtBookname = new System.Windows.Forms.TextBox();
            this.txtPublish_Number = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtbookauthor = new System.Windows.Forms.TextBox();
            this.txtbooktranslater = new System.Windows.Forms.TextBox();
            this.txtBookcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.updatebook = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(684, 496);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lnum
            // 
            this.lnum.AutoSize = true;
            this.lnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lnum.ForeColor = System.Drawing.Color.Red;
            this.lnum.Location = new System.Drawing.Point(710, 342);
            this.lnum.Name = "lnum";
            this.lnum.Size = new System.Drawing.Size(15, 20);
            this.lnum.TabIndex = 29;
            this.lnum.Text = "*";
            // 
            // lsha
            // 
            this.lsha.AutoSize = true;
            this.lsha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lsha.ForeColor = System.Drawing.Color.Red;
            this.lsha.Location = new System.Drawing.Point(710, 276);
            this.lsha.Name = "lsha";
            this.lsha.Size = new System.Drawing.Size(15, 20);
            this.lsha.TabIndex = 36;
            this.lsha.Text = "*";
            // 
            // lsal
            // 
            this.lsal.AutoSize = true;
            this.lsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lsal.ForeColor = System.Drawing.Color.Red;
            this.lsal.Location = new System.Drawing.Point(710, 243);
            this.lsal.Name = "lsal";
            this.lsal.Size = new System.Drawing.Size(15, 20);
            this.lsal.TabIndex = 35;
            this.lsal.Text = "*";
            // 
            // lpubli
            // 
            this.lpubli.AutoSize = true;
            this.lpubli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lpubli.ForeColor = System.Drawing.Color.Red;
            this.lpubli.Location = new System.Drawing.Point(710, 210);
            this.lpubli.Name = "lpubli";
            this.lpubli.Size = new System.Drawing.Size(15, 20);
            this.lpubli.TabIndex = 34;
            this.lpubli.Text = "*";
            // 
            // lath
            // 
            this.lath.AutoSize = true;
            this.lath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lath.ForeColor = System.Drawing.Color.Red;
            this.lath.Location = new System.Drawing.Point(710, 111);
            this.lath.Name = "lath";
            this.lath.Size = new System.Drawing.Size(15, 20);
            this.lath.TabIndex = 33;
            this.lath.Text = "*";
            // 
            // lnam
            // 
            this.lnam.AutoSize = true;
            this.lnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lnam.ForeColor = System.Drawing.Color.Red;
            this.lnam.Location = new System.Drawing.Point(710, 78);
            this.lnam.Name = "lnam";
            this.lnam.Size = new System.Drawing.Size(15, 20);
            this.lnam.TabIndex = 32;
            this.lnam.Text = "*";
            // 
            // lkod
            // 
            this.lkod.AutoSize = true;
            this.lkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lkod.ForeColor = System.Drawing.Color.Red;
            this.lkod.Location = new System.Drawing.Point(710, 45);
            this.lkod.Name = "lkod";
            this.lkod.Size = new System.Drawing.Size(15, 20);
            this.lkod.TabIndex = 31;
            this.lkod.Text = "*";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("IRNazanin", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(827, 424);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAdd.Size = new System.Drawing.Size(100, 31);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "ثبت کتاب";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtshabak
            // 
            this.txtshabak.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtshabak.Location = new System.Drawing.Point(745, 273);
            this.txtshabak.Name = "txtshabak";
            this.txtshabak.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtshabak.Size = new System.Drawing.Size(100, 31);
            this.txtshabak.TabIndex = 30;
            this.txtshabak.TextChanged += new System.EventHandler(this.txtshabak_TextChanged);
            // 
            // txtbooktitle
            // 
            this.txtbooktitle.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbooktitle.Location = new System.Drawing.Point(745, 141);
            this.txtbooktitle.Name = "txtbooktitle";
            this.txtbooktitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbooktitle.Size = new System.Drawing.Size(100, 31);
            this.txtbooktitle.TabIndex = 25;
            // 
            // txtbookcategory
            // 
            this.txtbookcategory.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookcategory.Location = new System.Drawing.Point(745, 306);
            this.txtbookcategory.Name = "txtbookcategory";
            this.txtbookcategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbookcategory.Size = new System.Drawing.Size(100, 31);
            this.txtbookcategory.TabIndex = 37;
            // 
            // txtpublisher
            // 
            this.txtpublisher.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpublisher.Location = new System.Drawing.Point(745, 207);
            this.txtpublisher.Name = "txtpublisher";
            this.txtpublisher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtpublisher.Size = new System.Drawing.Size(100, 31);
            this.txtpublisher.TabIndex = 27;
            // 
            // txtBookname
            // 
            this.txtBookname.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookname.Location = new System.Drawing.Point(745, 75);
            this.txtBookname.Name = "txtBookname";
            this.txtBookname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBookname.Size = new System.Drawing.Size(100, 31);
            this.txtBookname.TabIndex = 23;
            this.txtBookname.TextChanged += new System.EventHandler(this.txtBookname_TextChanged);
            // 
            // txtPublish_Number
            // 
            this.txtPublish_Number.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublish_Number.Location = new System.Drawing.Point(745, 339);
            this.txtPublish_Number.Name = "txtPublish_Number";
            this.txtPublish_Number.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPublish_Number.Size = new System.Drawing.Size(100, 31);
            this.txtPublish_Number.TabIndex = 38;
            this.txtPublish_Number.TextChanged += new System.EventHandler(this.txtPublish_Number_TextChanged);
            // 
            // txtyear
            // 
            this.txtyear.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyear.Location = new System.Drawing.Point(745, 240);
            this.txtyear.Name = "txtyear";
            this.txtyear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtyear.Size = new System.Drawing.Size(100, 31);
            this.txtyear.TabIndex = 28;
            this.txtyear.TextChanged += new System.EventHandler(this.txtyear_TextChanged);
            // 
            // txtbookauthor
            // 
            this.txtbookauthor.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookauthor.Location = new System.Drawing.Point(745, 108);
            this.txtbookauthor.Name = "txtbookauthor";
            this.txtbookauthor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbookauthor.Size = new System.Drawing.Size(100, 31);
            this.txtbookauthor.TabIndex = 24;
            // 
            // txtbooktranslater
            // 
            this.txtbooktranslater.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbooktranslater.Location = new System.Drawing.Point(745, 174);
            this.txtbooktranslater.Name = "txtbooktranslater";
            this.txtbooktranslater.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbooktranslater.Size = new System.Drawing.Size(100, 31);
            this.txtbooktranslater.TabIndex = 26;
            // 
            // txtBookcode
            // 
            this.txtBookcode.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookcode.Location = new System.Drawing.Point(745, 42);
            this.txtBookcode.Name = "txtBookcode";
            this.txtBookcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBookcode.Size = new System.Drawing.Size(100, 31);
            this.txtBookcode.TabIndex = 21;
            this.txtBookcode.TextChanged += new System.EventHandler(this.txtBookcode_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(877, 276);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(42, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "شابک";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(859, 342);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(64, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "شماره نشر";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(856, 243);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "سال انتشار";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(876, 141);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "عنوان";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(871, 306);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(48, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "موضوع";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(866, 210);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "انتشارات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(869, 107);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "نویسنده";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(874, 174);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "مترجم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(869, 78);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "نام کتاب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(871, 45);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "کد کتاب";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("IRNazanin", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(827, 461);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 39;
            this.button1.Text = "حذف کتاب";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updatebook
            // 
            this.updatebook.Font = new System.Drawing.Font("IRNazanin", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebook.Location = new System.Drawing.Point(717, 423);
            this.updatebook.Name = "updatebook";
            this.updatebook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.updatebook.Size = new System.Drawing.Size(100, 31);
            this.updatebook.TabIndex = 40;
            this.updatebook.Text = "بروزرسانی";
            this.updatebook.UseVisualStyleBackColor = true;
            this.updatebook.Click += new System.EventHandler(this.updatebook_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("IRNazanin", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(717, 460);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(100, 31);
            this.button2.TabIndex = 41;
            this.button2.Text = "پاک کردن";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("IRNazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(745, 392);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 25);
            this.lblMsg.TabIndex = 42;
            // 
            // book_managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(939, 519);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.updatebook);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lnum);
            this.Controls.Add(this.lsha);
            this.Controls.Add(this.lsal);
            this.Controls.Add(this.lpubli);
            this.Controls.Add(this.lath);
            this.Controls.Add(this.lnam);
            this.Controls.Add(this.lkod);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtshabak);
            this.Controls.Add(this.txtbooktitle);
            this.Controls.Add(this.txtbookcategory);
            this.Controls.Add(this.txtpublisher);
            this.Controls.Add(this.txtBookname);
            this.Controls.Add(this.txtPublish_Number);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtbookauthor);
            this.Controls.Add(this.txtbooktranslater);
            this.Controls.Add(this.txtBookcode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "book_managment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت کتاب ها";
            this.Load += new System.EventHandler(this.book_managment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lnum;
        private System.Windows.Forms.Label lsha;
        private System.Windows.Forms.Label lsal;
        private System.Windows.Forms.Label lpubli;
        private System.Windows.Forms.Label lath;
        private System.Windows.Forms.Label lnam;
        private System.Windows.Forms.Label lkod;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtshabak;
        private System.Windows.Forms.TextBox txtbooktitle;
        private System.Windows.Forms.TextBox txtbookcategory;
        private System.Windows.Forms.TextBox txtpublisher;
        private System.Windows.Forms.TextBox txtBookname;
        private System.Windows.Forms.TextBox txtPublish_Number;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtbookauthor;
        private System.Windows.Forms.TextBox txtbooktranslater;
        private System.Windows.Forms.TextBox txtBookcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button updatebook;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblMsg;
    }
}