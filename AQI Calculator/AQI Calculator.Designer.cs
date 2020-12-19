namespace AQI_Calculator
{
    partial class frmMain
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
            this.rdbtnPunjabaqi = new System.Windows.Forms.RadioButton();
            this.lblMain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbtnUsaqi = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPollutant = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAqi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAqicategory = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbtnPunjabaqi
            // 
            this.rdbtnPunjabaqi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnPunjabaqi.Location = new System.Drawing.Point(77, 87);
            this.rdbtnPunjabaqi.Name = "rdbtnPunjabaqi";
            this.rdbtnPunjabaqi.Size = new System.Drawing.Size(103, 22);
            this.rdbtnPunjabaqi.TabIndex = 0;
            this.rdbtnPunjabaqi.Text = "Punjab AQI";
            this.rdbtnPunjabaqi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.rdbtnPunjabaqi.UseVisualStyleBackColor = true;
            this.rdbtnPunjabaqi.CheckedChanged += new System.EventHandler(this.rdbtnPunjabaqi_CheckedChanged);
            // 
            // lblMain
            // 
            this.lblMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMain.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(0, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(624, 44);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "AQI Calculator";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select region:";
            // 
            // rdbtnUsaqi
            // 
            this.rdbtnUsaqi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnUsaqi.Location = new System.Drawing.Point(228, 87);
            this.rdbtnUsaqi.Name = "rdbtnUsaqi";
            this.rdbtnUsaqi.Size = new System.Drawing.Size(77, 22);
            this.rdbtnUsaqi.TabIndex = 3;
            this.rdbtnUsaqi.Text = "US AQI";
            this.rdbtnUsaqi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.rdbtnUsaqi.UseVisualStyleBackColor = true;
            this.rdbtnUsaqi.CheckedChanged += new System.EventHandler(this.rdbtnUsaqi_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Pollutant:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPollutant
            // 
            this.cmbPollutant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPollutant.FormattingEnabled = true;
            this.cmbPollutant.Location = new System.Drawing.Point(77, 163);
            this.cmbPollutant.Name = "cmbPollutant";
            this.cmbPollutant.Size = new System.Drawing.Size(228, 21);
            this.cmbPollutant.TabIndex = 5;
            this.cmbPollutant.SelectedIndexChanged += new System.EventHandler(this.cmbPollutant_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter the Concentration:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxValue
            // 
            this.txtBoxValue.Location = new System.Drawing.Point(77, 305);
            this.txtBoxValue.Name = "txtBoxValue";
            this.txtBoxValue.Size = new System.Drawing.Size(228, 20);
            this.txtBoxValue.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 48);
            this.label4.TabIndex = 8;
            this.label4.Text = "AQI:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAqi
            // 
            this.lblAqi.AutoSize = true;
            this.lblAqi.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAqi.Location = new System.Drawing.Point(73, 376);
            this.lblAqi.Name = "lblAqi";
            this.lblAqi.Size = new System.Drawing.Size(18, 19);
            this.lblAqi.TabIndex = 9;
            this.lblAqi.Text = "0";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(177, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 48);
            this.label6.TabIndex = 10;
            this.label6.Text = "AQI Category:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAqicategory
            // 
            this.lblAqicategory.AutoSize = true;
            this.lblAqicategory.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAqicategory.Location = new System.Drawing.Point(224, 376);
            this.lblAqicategory.Name = "lblAqicategory";
            this.lblAqicategory.Size = new System.Drawing.Size(35, 19);
            this.lblAqicategory.TabIndex = 11;
            this.lblAqicategory.Text = "NIL";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 48);
            this.label5.TabIndex = 12;
            this.label5.Text = "Unit:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(73, 235);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(40, 19);
            this.lblUnit.TabIndex = 13;
            this.lblUnit.Text = "Unit";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(348, 296);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(87, 34);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(441, 296);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 34);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 448);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAqicategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAqi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPollutant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbtnUsaqi);
            this.Controls.Add(this.rdbtnPunjabaqi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AQI Calculator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnPunjabaqi;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbtnUsaqi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPollutant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAqi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAqicategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
    }
}

