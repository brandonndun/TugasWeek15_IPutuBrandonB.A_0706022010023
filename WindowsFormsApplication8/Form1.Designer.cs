namespace WindowsFormsApplication8
{
    partial class NamaItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.InputButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MakananCheck = new System.Windows.Forms.CheckBox();
            this.MinumanCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxName1 = new System.Windows.Forms.ListBox();
            this.boxName2 = new System.Windows.Forms.ListBox();
            this.BoxItem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Makanan";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(94, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Minuman";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // InputButton
            // 
            this.InputButton.Location = new System.Drawing.Point(142, 114);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(75, 23);
            this.InputButton.TabIndex = 6;
            this.InputButton.Text = "Input";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(244, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(244, 202);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "X";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // MakananCheck
            // 
            this.MakananCheck.AutoSize = true;
            this.MakananCheck.Location = new System.Drawing.Point(244, 274);
            this.MakananCheck.Name = "MakananCheck";
            this.MakananCheck.Size = new System.Drawing.Size(71, 17);
            this.MakananCheck.TabIndex = 10;
            this.MakananCheck.Text = "Makanan";
            this.MakananCheck.UseVisualStyleBackColor = true;
            this.MakananCheck.CheckedChanged += new System.EventHandler(this.MakananCheck_CheckedChanged);
            // 
            // MinumanCheck
            // 
            this.MinumanCheck.AutoSize = true;
            this.MinumanCheck.Location = new System.Drawing.Point(244, 297);
            this.MinumanCheck.Name = "MinumanCheck";
            this.MinumanCheck.Size = new System.Drawing.Size(69, 17);
            this.MinumanCheck.TabIndex = 11;
            this.MinumanCheck.Text = "Minuman";
            this.MinumanCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Filter";
            // 
            // boxName1
            // 
            this.boxName1.FormattingEnabled = true;
            this.boxName1.Location = new System.Drawing.Point(33, 163);
            this.boxName1.Name = "boxName1";
            this.boxName1.Size = new System.Drawing.Size(145, 147);
            this.boxName1.TabIndex = 13;
            this.boxName1.SelectedIndexChanged += new System.EventHandler(this.boxName1_SelectedIndexChanged);
            // 
            // boxName2
            // 
            this.boxName2.FormattingEnabled = true;
            this.boxName2.Location = new System.Drawing.Point(405, 163);
            this.boxName2.Name = "boxName2";
            this.boxName2.Size = new System.Drawing.Size(105, 147);
            this.boxName2.TabIndex = 14;
            // 
            // BoxItem
            // 
            this.BoxItem.Location = new System.Drawing.Point(129, 24);
            this.BoxItem.Name = "BoxItem";
            this.BoxItem.Size = new System.Drawing.Size(141, 20);
            this.BoxItem.TabIndex = 15;
            this.BoxItem.TextChanged += new System.EventHandler(this.BoxItem_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(129, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 51);
            this.panel1.TabIndex = 16;
            // 
            // NamaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 326);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BoxItem);
            this.Controls.Add(this.boxName2);
            this.Controls.Add(this.boxName1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MinumanCheck);
            this.Controls.Add(this.MakananCheck);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NamaItem";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NamaItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.CheckBox MakananCheck;
        private System.Windows.Forms.CheckBox MinumanCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox boxName1;
        private System.Windows.Forms.ListBox boxName2;
        private System.Windows.Forms.TextBox BoxItem;
        private System.Windows.Forms.Panel panel1;
    }
}

