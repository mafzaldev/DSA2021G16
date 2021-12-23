
namespace Ambulance_service.Forms
{
    partial class AddAmbulance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAmbulance));
            this.label1 = new System.Windows.Forms.Label();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ambType1 = new System.Windows.Forms.RadioButton();
            this.ambType2 = new System.Windows.Forms.RadioButton();
            this.ambType4 = new System.Windows.Forms.RadioButton();
            this.ambType3 = new System.Windows.Forms.RadioButton();
            this.initiateLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD AMBULANCE";
            // 
            // userNameInput
            // 
            this.userNameInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameInput.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.userNameInput.Location = new System.Drawing.Point(27, 184);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(328, 34);
            this.userNameInput.TabIndex = 2;
            this.userNameInput.Text = "Number Plate";
            this.userNameInput.Click += new System.EventHandler(this.numPlate_clicked);
            this.userNameInput.Leave += new System.EventHandler(this.numPlate_leave);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(27, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(328, 34);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Unique ID";
            this.textBox2.Click += new System.EventHandler(this.ID_clicked);
            this.textBox2.Leave += new System.EventHandler(this.ID_leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ambulance Type";
            // 
            // ambType1
            // 
            this.ambType1.AutoSize = true;
            this.ambType1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambType1.Location = new System.Drawing.Point(27, 272);
            this.ambType1.Name = "ambType1";
            this.ambType1.Size = new System.Drawing.Size(67, 25);
            this.ambType1.TabIndex = 5;
            this.ambType1.TabStop = true;
            this.ambType1.Text = "Bolan";
            this.ambType1.UseVisualStyleBackColor = true;
            // 
            // ambType2
            // 
            this.ambType2.AutoSize = true;
            this.ambType2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambType2.Location = new System.Drawing.Point(136, 272);
            this.ambType2.Name = "ambType2";
            this.ambType2.Size = new System.Drawing.Size(66, 25);
            this.ambType2.TabIndex = 6;
            this.ambType2.TabStop = true;
            this.ambType2.Text = "Hiace";
            this.ambType2.UseVisualStyleBackColor = true;
            // 
            // ambType4
            // 
            this.ambType4.AutoSize = true;
            this.ambType4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambType4.Location = new System.Drawing.Point(343, 272);
            this.ambType4.Name = "ambType4";
            this.ambType4.Size = new System.Drawing.Size(84, 25);
            this.ambType4.TabIndex = 7;
            this.ambType4.TabStop = true;
            this.ambType4.Text = "Karvaan";
            this.ambType4.UseVisualStyleBackColor = true;
            // 
            // ambType3
            // 
            this.ambType3.AutoSize = true;
            this.ambType3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambType3.Location = new System.Drawing.Point(244, 272);
            this.ambType3.Name = "ambType3";
            this.ambType3.Size = new System.Drawing.Size(57, 25);
            this.ambType3.TabIndex = 8;
            this.ambType3.TabStop = true;
            this.ambType3.Text = "APV";
            this.ambType3.UseVisualStyleBackColor = true;
            // 
            // initiateLogin
            // 
            this.initiateLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.initiateLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.initiateLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initiateLogin.Location = new System.Drawing.Point(27, 317);
            this.initiateLogin.Name = "initiateLogin";
            this.initiateLogin.Size = new System.Drawing.Size(146, 36);
            this.initiateLogin.TabIndex = 9;
            this.initiateLogin.Text = "Add ambulance";
            this.initiateLogin.UseVisualStyleBackColor = true;
            this.initiateLogin.Click += new System.EventHandler(this.Addambulance_clicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(560, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // AddAmbulance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 621);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.initiateLogin);
            this.Controls.Add(this.ambType3);
            this.Controls.Add(this.ambType4);
            this.Controls.Add(this.ambType2);
            this.Controls.Add(this.ambType1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.label1);
            this.Name = "AddAmbulance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAmbulance";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton ambType1;
        private System.Windows.Forms.RadioButton ambType2;
        private System.Windows.Forms.RadioButton ambType4;
        private System.Windows.Forms.RadioButton ambType3;
        private System.Windows.Forms.Button initiateLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}