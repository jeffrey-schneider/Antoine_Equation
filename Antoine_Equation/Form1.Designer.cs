namespace Antoine_Equation
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
            this.DGV01 = new System.Windows.Forms.DataGridView();
            this.TxtBoxOutput01 = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.TxtTemperatureInput = new System.Windows.Forms.TextBox();
            this.TxtCASNInput = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGV02 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV01)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV02)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV01
            // 
            this.DGV01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV01.Location = new System.Drawing.Point(34, 29);
            this.DGV01.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV01.MultiSelect = false;
            this.DGV01.Name = "DGV01";
            this.DGV01.ReadOnly = true;
            this.DGV01.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV01.Size = new System.Drawing.Size(1396, 373);
            this.DGV01.TabIndex = 0;
            this.DGV01.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1_CellFormatting);
            // 
            // TxtBoxOutput01
            // 
            this.TxtBoxOutput01.Location = new System.Drawing.Point(362, 442);
            this.TxtBoxOutput01.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBoxOutput01.Multiline = true;
            this.TxtBoxOutput01.Name = "TxtBoxOutput01";
            this.TxtBoxOutput01.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtBoxOutput01.Size = new System.Drawing.Size(841, 164);
            this.TxtBoxOutput01.TabIndex = 1;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSubmit.Location = new System.Drawing.Point(1228, 442);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(202, 78);
            this.BtnSubmit.TabIndex = 2;
            this.BtnSubmit.Text = "&Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TxtTemperatureInput
            // 
            this.TxtTemperatureInput.Location = new System.Drawing.Point(226, 448);
            this.TxtTemperatureInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTemperatureInput.Name = "TxtTemperatureInput";
            this.TxtTemperatureInput.Size = new System.Drawing.Size(105, 29);
            this.TxtTemperatureInput.TabIndex = 3;
            // 
            // TxtCASNInput
            // 
            this.TxtCASNInput.Location = new System.Drawing.Point(226, 487);
            this.TxtCASNInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCASNInput.Name = "TxtCASNInput";
            this.TxtCASNInput.Size = new System.Drawing.Size(105, 29);
            this.TxtCASNInput.TabIndex = 4;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(1228, 530);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(202, 78);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "Search for CASN";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Temperature(C)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "CASN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vapor Pressure (mmHg)";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(226, 532);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(105, 29);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(226, 583);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(105, 29);
            this.textBox5.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 580);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vapor Pressure(k_Pa)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 632);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Vapor Pressure(Bar)";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(226, 635);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(105, 29);
            this.textBox6.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1528, 800);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox7);
            this.tabPage1.Controls.Add(this.DGV01);
            this.tabPage1.Controls.Add(this.TxtBoxOutput01);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.BtnSubmit);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.BtnSearch);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.TxtTemperatureInput);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.TxtCASNInput);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1520, 766);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(362, 629);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox7.Size = new System.Drawing.Size(270, 118);
            this.textBox7.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGV02);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1520, 766);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGV02
            // 
            this.DGV02.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV02.Location = new System.Drawing.Point(344, 31);
            this.DGV02.Name = "DGV02";
            this.DGV02.Size = new System.Drawing.Size(552, 541);
            this.DGV02.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 890);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Antoine Equation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV01)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV02)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV01;
        private System.Windows.Forms.TextBox TxtBoxOutput01;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.TextBox TxtTemperatureInput;
        private System.Windows.Forms.TextBox TxtCASNInput;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGV02;
        private System.Windows.Forms.TextBox textBox7;
    }
}

