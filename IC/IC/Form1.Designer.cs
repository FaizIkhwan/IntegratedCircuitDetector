namespace IC
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.picRaw = new System.Windows.Forms.PictureBox();
            this.picConv = new System.Windows.Forms.PictureBox();
            this.picRes = new System.Windows.Forms.PictureBox();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.trackBarTreshold = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalIC = new System.Windows.Forms.Label();
            this.labelIntel = new System.Windows.Forms.Label();
            this.labelAtmet = new System.Windows.Forms.Label();
            this.labelTreshold = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Raw Image";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(332, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Converted Image";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox3.Location = new System.Drawing.Point(648, 13);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 26);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Result Image";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox4.Location = new System.Drawing.Point(968, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Data";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox5.Location = new System.Drawing.Point(968, 379);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Category";
            // 
            // picRaw
            // 
            this.picRaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRaw.Location = new System.Drawing.Point(13, 51);
            this.picRaw.Name = "picRaw";
            this.picRaw.Size = new System.Drawing.Size(300, 300);
            this.picRaw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRaw.TabIndex = 5;
            this.picRaw.TabStop = false;
            // 
            // picConv
            // 
            this.picConv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picConv.Location = new System.Drawing.Point(332, 51);
            this.picConv.Name = "picConv";
            this.picConv.Size = new System.Drawing.Size(300, 300);
            this.picConv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picConv.TabIndex = 6;
            this.picConv.TabStop = false;
            // 
            // picRes
            // 
            this.picRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRes.Location = new System.Drawing.Point(648, 51);
            this.picRes.Name = "picRes";
            this.picRes.Size = new System.Drawing.Size(300, 300);
            this.picRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRes.TabIndex = 7;
            this.picRes.TabStop = false;
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(968, 51);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(212, 303);
            this.listBoxData.TabIndex = 8;
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.Location = new System.Drawing.Point(968, 420);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(212, 160);
            this.listBoxCategory.TabIndex = 9;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.Location = new System.Drawing.Point(13, 367);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(100, 62);
            this.buttonBrowse.TabIndex = 10;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox6.Location = new System.Drawing.Point(13, 464);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 26);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "Treshold";
            // 
            // trackBarTreshold
            // 
            this.trackBarTreshold.Location = new System.Drawing.Point(13, 499);
            this.trackBarTreshold.Maximum = 300;
            this.trackBarTreshold.Name = "trackBarTreshold";
            this.trackBarTreshold.Size = new System.Drawing.Size(379, 45);
            this.trackBarTreshold.TabIndex = 12;
            this.trackBarTreshold.Scroll += new System.EventHandler(this.trackBarTreshold_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Total count IC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Intel IC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Atmet IC:";
            // 
            // labelTotalIC
            // 
            this.labelTotalIC.AutoSize = true;
            this.labelTotalIC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotalIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalIC.Location = new System.Drawing.Point(682, 382);
            this.labelTotalIC.Name = "labelTotalIC";
            this.labelTotalIC.Size = new System.Drawing.Size(19, 20);
            this.labelTotalIC.TabIndex = 16;
            this.labelTotalIC.Text = "0";
            // 
            // labelIntel
            // 
            this.labelIntel.AutoSize = true;
            this.labelIntel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIntel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelIntel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntel.Location = new System.Drawing.Point(682, 464);
            this.labelIntel.Name = "labelIntel";
            this.labelIntel.Size = new System.Drawing.Size(19, 20);
            this.labelIntel.TabIndex = 17;
            this.labelIntel.Text = "0";
            // 
            // labelAtmet
            // 
            this.labelAtmet.AutoSize = true;
            this.labelAtmet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAtmet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAtmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAtmet.Location = new System.Drawing.Point(682, 550);
            this.labelAtmet.Name = "labelAtmet";
            this.labelAtmet.Size = new System.Drawing.Size(19, 20);
            this.labelAtmet.TabIndex = 18;
            this.labelAtmet.Text = "0";
            // 
            // labelTreshold
            // 
            this.labelTreshold.AutoSize = true;
            this.labelTreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTreshold.Location = new System.Drawing.Point(415, 499);
            this.labelTreshold.Name = "labelTreshold";
            this.labelTreshold.Size = new System.Drawing.Size(34, 22);
            this.labelTreshold.TabIndex = 19;
            this.labelTreshold.Text = "0%";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Png files|*.png";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 605);
            this.Controls.Add(this.labelTreshold);
            this.Controls.Add(this.labelAtmet);
            this.Controls.Add(this.labelIntel);
            this.Controls.Add(this.labelTotalIC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarTreshold);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.listBoxCategory);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.picRes);
            this.Controls.Add(this.picConv);
            this.Controls.Add(this.picRaw);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Integrated Circuit Detector";
            ((System.ComponentModel.ISupportInitialize)(this.picRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox picRaw;
        private System.Windows.Forms.PictureBox picConv;
        private System.Windows.Forms.PictureBox picRes;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TrackBar trackBarTreshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalIC;
        private System.Windows.Forms.Label labelIntel;
        private System.Windows.Forms.Label labelAtmet;
        private System.Windows.Forms.Label labelTreshold;       
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

