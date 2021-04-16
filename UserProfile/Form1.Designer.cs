
namespace UserProfile
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.checkBoxUG = new System.Windows.Forms.CheckBox();
            this.checkBoxPG = new System.Windows.Forms.CheckBox();
            this.checkBoxPlusTwo = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Education";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Upload Image";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(257, 92);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(257, 158);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 6;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(257, 227);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(48, 17);
            this.radioMale.TabIndex = 7;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(356, 227);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(59, 17);
            this.radioFemale.TabIndex = 8;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // pictureProfile
            // 
            this.pictureProfile.Location = new System.Drawing.Point(245, 342);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(221, 147);
            this.pictureProfile.TabIndex = 13;
            this.pictureProfile.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(43, 503);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 42);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(394, 82);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(91, 30);
            this.btnRead.TabIndex = 15;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(494, 347);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(91, 29);
            this.btnBrowse.TabIndex = 16;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // checkBoxUG
            // 
            this.checkBoxUG.AutoSize = true;
            this.checkBoxUG.Location = new System.Drawing.Point(275, 293);
            this.checkBoxUG.Name = "checkBoxUG";
            this.checkBoxUG.Size = new System.Drawing.Size(42, 17);
            this.checkBoxUG.TabIndex = 17;
            this.checkBoxUG.Text = "UG";
            this.checkBoxUG.UseVisualStyleBackColor = true;
            // 
            // checkBoxPG
            // 
            this.checkBoxPG.AutoSize = true;
            this.checkBoxPG.Location = new System.Drawing.Point(374, 293);
            this.checkBoxPG.Name = "checkBoxPG";
            this.checkBoxPG.Size = new System.Drawing.Size(41, 17);
            this.checkBoxPG.TabIndex = 18;
            this.checkBoxPG.Text = "PG";
            this.checkBoxPG.UseVisualStyleBackColor = true;
            // 
            // checkBoxPlusTwo
            // 
            this.checkBoxPlusTwo.AutoSize = true;
            this.checkBoxPlusTwo.Location = new System.Drawing.Point(443, 293);
            this.checkBoxPlusTwo.Name = "checkBoxPlusTwo";
            this.checkBoxPlusTwo.Size = new System.Drawing.Size(67, 17);
            this.checkBoxPlusTwo.TabIndex = 19;
            this.checkBoxPlusTwo.Text = "PlusTwo";
            this.checkBoxPlusTwo.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(520, 293);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(38, 17);
            this.checkBox10.TabIndex = 20;
            this.checkBox10.Text = "10";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 557);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBoxPlusTwo);
            this.Controls.Add(this.checkBoxPG);
            this.Controls.Add(this.checkBoxUG);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureProfile);
            this.Controls.Add(this.radioFemale);
            this.Controls.Add(this.radioMale);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.PictureBox pictureProfile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.CheckBox checkBoxUG;
        private System.Windows.Forms.CheckBox checkBoxPG;
        private System.Windows.Forms.CheckBox checkBoxPlusTwo;
        private System.Windows.Forms.CheckBox checkBox10;
    }
}

