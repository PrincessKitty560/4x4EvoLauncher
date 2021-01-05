
namespace _4x4Evo_Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ClassGUID_Box = new System.Windows.Forms.TextBox();
            this.InstancePath_Box = new System.Windows.Forms.TextBox();
            this.GameFile_Box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Accept_Button = new System.Windows.Forms.Button();
            this.Help_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ClassGUID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "InstancePath";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "GameFile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ClassGUID of the device needing to be disabled";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "InstanceClass of the device needing to be disabled";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Executable file of your game";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ClassGUID_Box
            // 
            this.ClassGUID_Box.Location = new System.Drawing.Point(151, 61);
            this.ClassGUID_Box.Name = "ClassGUID_Box";
            this.ClassGUID_Box.Size = new System.Drawing.Size(180, 20);
            this.ClassGUID_Box.TabIndex = 6;
            // 
            // InstancePath_Box
            // 
            this.InstancePath_Box.Location = new System.Drawing.Point(151, 153);
            this.InstancePath_Box.Name = "InstancePath_Box";
            this.InstancePath_Box.Size = new System.Drawing.Size(180, 20);
            this.InstancePath_Box.TabIndex = 7;
            // 
            // GameFile_Box
            // 
            this.GameFile_Box.Location = new System.Drawing.Point(151, 245);
            this.GameFile_Box.Name = "GameFile_Box";
            this.GameFile_Box.Size = new System.Drawing.Size(180, 20);
            this.GameFile_Box.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Accept_Button
            // 
            this.Accept_Button.Location = new System.Drawing.Point(167, 306);
            this.Accept_Button.Name = "Accept_Button";
            this.Accept_Button.Size = new System.Drawing.Size(140, 41);
            this.Accept_Button.TabIndex = 10;
            this.Accept_Button.Text = "Accept";
            this.Accept_Button.UseVisualStyleBackColor = true;
            this.Accept_Button.Click += new System.EventHandler(this.Accept_Button_Click);
            // 
            // Help_Button
            // 
            this.Help_Button.Location = new System.Drawing.Point(432, 325);
            this.Help_Button.Name = "Help_Button";
            this.Help_Button.Size = new System.Drawing.Size(54, 40);
            this.Help_Button.TabIndex = 11;
            this.Help_Button.Text = "HELP";
            this.Help_Button.UseVisualStyleBackColor = true;
            this.Help_Button.Click += new System.EventHandler(this.Help_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 377);
            this.Controls.Add(this.Help_Button);
            this.Controls.Add(this.Accept_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GameFile_Box);
            this.Controls.Add(this.InstancePath_Box);
            this.Controls.Add(this.ClassGUID_Box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox ClassGUID_Box;
        private System.Windows.Forms.TextBox InstancePath_Box;
        private System.Windows.Forms.TextBox GameFile_Box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Accept_Button;
        private System.Windows.Forms.Button Help_Button;
    }
}

