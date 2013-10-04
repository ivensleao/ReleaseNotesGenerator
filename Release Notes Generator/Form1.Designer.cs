namespace Release_Notes_Generator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_version = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_about = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_additions = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_bugs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_file = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version:";
            // 
            // txt_version
            // 
            this.txt_version.Location = new System.Drawing.Point(462, 47);
            this.txt_version.Name = "txt_version";
            this.txt_version.Size = new System.Drawing.Size(306, 20);
            this.txt_version.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Levenim MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "About:";
            // 
            // txt_about
            // 
            this.txt_about.Location = new System.Drawing.Point(89, 93);
            this.txt_about.Multiline = true;
            this.txt_about.Name = "txt_about";
            this.txt_about.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_about.Size = new System.Drawing.Size(679, 40);
            this.txt_about.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Levenim MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Additions:";
            // 
            // txt_additions
            // 
            this.txt_additions.Location = new System.Drawing.Point(89, 151);
            this.txt_additions.Multiline = true;
            this.txt_additions.Name = "txt_additions";
            this.txt_additions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_additions.Size = new System.Drawing.Size(679, 137);
            this.txt_additions.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Levenim MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bugs:";
            // 
            // txt_bugs
            // 
            this.txt_bugs.Location = new System.Drawing.Point(89, 320);
            this.txt_bugs.Multiline = true;
            this.txt_bugs.Name = "txt_bugs";
            this.txt_bugs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_bugs.Size = new System.Drawing.Size(679, 123);
            this.txt_bugs.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Levenim MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = " Path:";
            // 
            // txt_path
            // 
            this.txt_path.Enabled = false;
            this.txt_path.Location = new System.Drawing.Point(89, 473);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(301, 20);
            this.txt_path.TabIndex = 9;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog1.InitialDirectory = "C:\\";
            this.saveFileDialog1.Title = "Select path to save your file:";
            // 
            // btn_file
            // 
            this.btn_file.Location = new System.Drawing.Point(396, 471);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(75, 23);
            this.btn_file.TabIndex = 10;
            this.btn_file.Text = "...";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(688, 529);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(607, 529);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_product
            // 
            this.txt_product.Location = new System.Drawing.Point(89, 47);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(301, 20);
            this.txt_product.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Levenim MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "Product:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 564);
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_bugs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_additions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_about);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_version);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Release Notes Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_version;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_about;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_additions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_bugs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.Label label6;
    }
}

