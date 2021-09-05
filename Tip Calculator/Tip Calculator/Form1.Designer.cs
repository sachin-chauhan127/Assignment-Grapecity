
namespace Tip_Calculator
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Nminus = new System.Windows.Forms.Button();
            this.Nplus = new System.Windows.Forms.Button();
            this.Tipminus = new System.Windows.Forms.Button();
            this.Tipplus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Persons = new System.Windows.Forms.TextBox();
            this.Tip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bill = new System.Windows.Forms.TextBox();
            this.Totalperperson = new System.Windows.Forms.TextBox();
            this.Tipperperson = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Totalpp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tipresult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Panel1.Controls.Add(this.Nminus);
            this.splitContainer1.Panel1.Controls.Add(this.Nplus);
            this.splitContainer1.Panel1.Controls.Add(this.Tipminus);
            this.splitContainer1.Panel1.Controls.Add(this.Tipplus);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.Persons);
            this.splitContainer1.Panel1.Controls.Add(this.Tip);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.Bill);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel2.Controls.Add(this.Totalperperson);
            this.splitContainer1.Panel2.Controls.Add(this.Tipperperson);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.Totalpp);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.Tipresult);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 309;
            this.splitContainer1.TabIndex = 0;
            // 
            // Nminus
            // 
            this.Nminus.Location = new System.Drawing.Point(47, 304);
            this.Nminus.Name = "Nminus";
            this.Nminus.Size = new System.Drawing.Size(34, 34);
            this.Nminus.TabIndex = 0;
            this.Nminus.Text = "-";
            this.Nminus.UseVisualStyleBackColor = true;
            this.Nminus.Click += new System.EventHandler(this.Nminus_Click);
            // 
            // Nplus
            // 
            this.Nplus.Location = new System.Drawing.Point(183, 304);
            this.Nplus.Name = "Nplus";
            this.Nplus.Size = new System.Drawing.Size(34, 34);
            this.Nplus.TabIndex = 0;
            this.Nplus.Text = "+";
            this.Nplus.UseVisualStyleBackColor = true;
            this.Nplus.Click += new System.EventHandler(this.Nplus_Click);
            // 
            // Tipminus
            // 
            this.Tipminus.Location = new System.Drawing.Point(47, 186);
            this.Tipminus.Name = "Tipminus";
            this.Tipminus.Size = new System.Drawing.Size(34, 34);
            this.Tipminus.TabIndex = 0;
            this.Tipminus.Text = "-";
            this.Tipminus.UseVisualStyleBackColor = true;
            this.Tipminus.Click += new System.EventHandler(this.Tipminus_Click);
            // 
            // Tipplus
            // 
            this.Tipplus.Location = new System.Drawing.Point(183, 186);
            this.Tipplus.Name = "Tipplus";
            this.Tipplus.Size = new System.Drawing.Size(34, 34);
            this.Tipplus.TabIndex = 2;
            this.Tipplus.Text = "+";
            this.Tipplus.UseVisualStyleBackColor = true;
            this.Tipplus.Click += new System.EventHandler(this.Tipplus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(43, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of people";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(43, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tip %";
            // 
            // Persons
            // 
            this.Persons.Enabled = false;
            this.Persons.Location = new System.Drawing.Point(82, 304);
            this.Persons.Multiline = true;
            this.Persons.Name = "Persons";
            this.Persons.Size = new System.Drawing.Size(99, 34);
            this.Persons.TabIndex = 0;
            this.Persons.Text = "1";
            this.Persons.TextChanged += new System.EventHandler(this.Persons_TextChanged);
            // 
            // Tip
            // 
            this.Tip.Enabled = false;
            this.Tip.Location = new System.Drawing.Point(82, 186);
            this.Tip.Multiline = true;
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(99, 34);
            this.Tip.TabIndex = 1;
            this.Tip.Text = "0";
            this.Tip.TextChanged += new System.EventHandler(this.Tip_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(43, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "BILL";
            // 
            // Bill
            // 
            this.Bill.Location = new System.Drawing.Point(47, 62);
            this.Bill.Multiline = true;
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(171, 34);
            this.Bill.TabIndex = 0;
            this.Bill.Text = "0.00";
            this.Bill.TextChanged += new System.EventHandler(this.Bill_TextChanged);
            // 
            // Totalperperson
            // 
            this.Totalperperson.Enabled = false;
            this.Totalperperson.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.Totalperperson.Location = new System.Drawing.Point(269, 222);
            this.Totalperperson.Multiline = true;
            this.Totalperperson.Name = "Totalperperson";
            this.Totalperperson.Size = new System.Drawing.Size(179, 61);
            this.Totalperperson.TabIndex = 7;
            this.Totalperperson.Text = "0.00";
            this.Totalperperson.TextChanged += new System.EventHandler(this.Totalperperson_TextChanged);
            // 
            // Tipperperson
            // 
            this.Tipperperson.Enabled = false;
            this.Tipperperson.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.Tipperperson.Location = new System.Drawing.Point(269, 114);
            this.Tipperperson.Multiline = true;
            this.Tipperperson.Name = "Tipperperson";
            this.Tipperperson.Size = new System.Drawing.Size(179, 55);
            this.Tipperperson.TabIndex = 6;
            this.Tipperperson.Text = "0.00";
            this.Tipperperson.TextChanged += new System.EventHandler(this.Tipperperson_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(232, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 54);
            this.label7.TabIndex = 5;
            this.label7.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 46);
            this.label6.TabIndex = 4;
            this.label6.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(81, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "per person";
            // 
            // Totalpp
            // 
            this.Totalpp.AutoSize = true;
            this.Totalpp.Font = new System.Drawing.Font("Showcard Gothic", 22.25F);
            this.Totalpp.Location = new System.Drawing.Point(78, 215);
            this.Totalpp.Name = "Totalpp";
            this.Totalpp.Size = new System.Drawing.Size(110, 37);
            this.Totalpp.TabIndex = 2;
            this.Totalpp.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(81, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "per person";
            // 
            // Tipresult
            // 
            this.Tipresult.AutoSize = true;
            this.Tipresult.Font = new System.Drawing.Font("Sigmar One", 22.25F);
            this.Tipresult.Location = new System.Drawing.Point(76, 94);
            this.Tipresult.Name = "Tipresult";
            this.Tipresult.Size = new System.Drawing.Size(78, 49);
            this.Tipresult.TabIndex = 0;
            this.Tipresult.Text = "Tip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Bill;
        private System.Windows.Forms.TextBox Tip;
        private System.Windows.Forms.TextBox Persons;
        private System.Windows.Forms.Button Tipplus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Tipminus;
        private System.Windows.Forms.Button Nminus;
        private System.Windows.Forms.Button Nplus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Totalpp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Tipresult;
        private System.Windows.Forms.TextBox Totalperperson;
        private System.Windows.Forms.TextBox Tipperperson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

