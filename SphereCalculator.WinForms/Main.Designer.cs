
namespace SphereCalculator.WinForms
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValue = new System.Windows.Forms.TextBox();
            this.rbRadius = new System.Windows.Forms.RadioButton();
            this.rbDiameter = new System.Windows.Forms.RadioButton();
            this.rbCircumference = new System.Windows.Forms.RadioButton();
            this.rbSurfaceArea = new System.Windows.Forms.RadioButton();
            this.rbVolume = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblRadius_Header = new System.Windows.Forms.Label();
            this.lblDiameter_Header = new System.Windows.Forms.Label();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblCircumference_Header = new System.Windows.Forms.Label();
            this.lblCircumference = new System.Windows.Forms.Label();
            this.lblSurfaceArea_Header = new System.Windows.Forms.Label();
            this.lblSurfaceArea = new System.Windows.Forms.Label();
            this.lblVolume_Header = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValue.Location = new System.Drawing.Point(0, 0);
            this.txtValue.Name = "txtValue";
            this.txtValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtValue.Size = new System.Drawing.Size(603, 35);
            this.txtValue.TabIndex = 0;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // rbRadius
            // 
            this.rbRadius.AutoSize = true;
            this.rbRadius.Checked = true;
            this.rbRadius.Location = new System.Drawing.Point(0, 51);
            this.rbRadius.Name = "rbRadius";
            this.rbRadius.Size = new System.Drawing.Size(60, 19);
            this.rbRadius.TabIndex = 1;
            this.rbRadius.TabStop = true;
            this.rbRadius.Text = "&Radius";
            this.rbRadius.UseVisualStyleBackColor = true;
            // 
            // rbDiameter
            // 
            this.rbDiameter.AutoSize = true;
            this.rbDiameter.Location = new System.Drawing.Point(105, 51);
            this.rbDiameter.Name = "rbDiameter";
            this.rbDiameter.Size = new System.Drawing.Size(73, 19);
            this.rbDiameter.TabIndex = 2;
            this.rbDiameter.Text = "&Diameter";
            this.rbDiameter.UseVisualStyleBackColor = true;
            // 
            // rbCircumference
            // 
            this.rbCircumference.AutoSize = true;
            this.rbCircumference.Location = new System.Drawing.Point(227, 51);
            this.rbCircumference.Name = "rbCircumference";
            this.rbCircumference.Size = new System.Drawing.Size(103, 19);
            this.rbCircumference.TabIndex = 3;
            this.rbCircumference.Text = "&Circumference";
            this.rbCircumference.UseVisualStyleBackColor = true;
            // 
            // rbSurfaceArea
            // 
            this.rbSurfaceArea.AutoSize = true;
            this.rbSurfaceArea.Location = new System.Drawing.Point(384, 51);
            this.rbSurfaceArea.Name = "rbSurfaceArea";
            this.rbSurfaceArea.Size = new System.Drawing.Size(91, 19);
            this.rbSurfaceArea.TabIndex = 4;
            this.rbSurfaceArea.Text = "&Surface Area";
            this.rbSurfaceArea.UseVisualStyleBackColor = true;
            // 
            // rbVolume
            // 
            this.rbVolume.AutoSize = true;
            this.rbVolume.Location = new System.Drawing.Point(538, 51);
            this.rbVolume.Name = "rbVolume";
            this.rbVolume.Size = new System.Drawing.Size(65, 19);
            this.rbVolume.TabIndex = 5;
            this.rbVolume.Text = "&Volume";
            this.rbVolume.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Black", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.Location = new System.Drawing.Point(0, 91);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(603, 76);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblRadius
            // 
            this.lblRadius.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRadius.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRadius.Location = new System.Drawing.Point(189, 181);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(408, 36);
            this.lblRadius.TabIndex = 7;
            this.lblRadius.Text = "-";
            this.lblRadius.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRadius_Header
            // 
            this.lblRadius_Header.Location = new System.Drawing.Point(6, 185);
            this.lblRadius_Header.Name = "lblRadius_Header";
            this.lblRadius_Header.Size = new System.Drawing.Size(177, 36);
            this.lblRadius_Header.TabIndex = 8;
            this.lblRadius_Header.Text = "Radius:";
            this.lblRadius_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiameter_Header
            // 
            this.lblDiameter_Header.Location = new System.Drawing.Point(6, 239);
            this.lblDiameter_Header.Name = "lblDiameter_Header";
            this.lblDiameter_Header.Size = new System.Drawing.Size(177, 36);
            this.lblDiameter_Header.TabIndex = 10;
            this.lblDiameter_Header.Text = "Diameter:";
            this.lblDiameter_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiameter
            // 
            this.lblDiameter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiameter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiameter.Location = new System.Drawing.Point(189, 239);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(408, 36);
            this.lblDiameter.TabIndex = 9;
            this.lblDiameter.Text = "-";
            this.lblDiameter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCircumference_Header
            // 
            this.lblCircumference_Header.Location = new System.Drawing.Point(6, 297);
            this.lblCircumference_Header.Name = "lblCircumference_Header";
            this.lblCircumference_Header.Size = new System.Drawing.Size(177, 36);
            this.lblCircumference_Header.TabIndex = 12;
            this.lblCircumference_Header.Text = "Circumference:";
            this.lblCircumference_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCircumference
            // 
            this.lblCircumference.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCircumference.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCircumference.Location = new System.Drawing.Point(189, 297);
            this.lblCircumference.Name = "lblCircumference";
            this.lblCircumference.Size = new System.Drawing.Size(408, 36);
            this.lblCircumference.TabIndex = 11;
            this.lblCircumference.Text = "-";
            this.lblCircumference.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSurfaceArea_Header
            // 
            this.lblSurfaceArea_Header.Location = new System.Drawing.Point(12, 355);
            this.lblSurfaceArea_Header.Name = "lblSurfaceArea_Header";
            this.lblSurfaceArea_Header.Size = new System.Drawing.Size(177, 36);
            this.lblSurfaceArea_Header.TabIndex = 14;
            this.lblSurfaceArea_Header.Text = "Surface Area:";
            this.lblSurfaceArea_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSurfaceArea
            // 
            this.lblSurfaceArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSurfaceArea.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSurfaceArea.Location = new System.Drawing.Point(189, 355);
            this.lblSurfaceArea.Name = "lblSurfaceArea";
            this.lblSurfaceArea.Size = new System.Drawing.Size(408, 36);
            this.lblSurfaceArea.TabIndex = 13;
            this.lblSurfaceArea.Text = "-";
            this.lblSurfaceArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVolume_Header
            // 
            this.lblVolume_Header.Location = new System.Drawing.Point(12, 413);
            this.lblVolume_Header.Name = "lblVolume_Header";
            this.lblVolume_Header.Size = new System.Drawing.Size(177, 36);
            this.lblVolume_Header.TabIndex = 16;
            this.lblVolume_Header.Text = "Volume:";
            this.lblVolume_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVolume
            // 
            this.lblVolume.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVolume.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVolume.Location = new System.Drawing.Point(189, 413);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(408, 36);
            this.lblVolume.TabIndex = 15;
            this.lblVolume.Text = "-";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 462);
            this.Controls.Add(this.lblVolume_Header);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblSurfaceArea_Header);
            this.Controls.Add(this.lblSurfaceArea);
            this.Controls.Add(this.lblCircumference_Header);
            this.Controls.Add(this.lblCircumference);
            this.Controls.Add(this.lblDiameter_Header);
            this.Controls.Add(this.lblDiameter);
            this.Controls.Add(this.lblRadius_Header);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rbVolume);
            this.Controls.Add(this.rbSurfaceArea);
            this.Controls.Add(this.rbCircumference);
            this.Controls.Add(this.rbDiameter);
            this.Controls.Add(this.rbRadius);
            this.Controls.Add(this.txtValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Sphere Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.RadioButton rbRadius;
        private System.Windows.Forms.RadioButton rbDiameter;
        private System.Windows.Forms.RadioButton rbCircumference;
        private System.Windows.Forms.RadioButton rbSurfaceArea;
        private System.Windows.Forms.RadioButton rbVolume;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblRadius_Header;
        private System.Windows.Forms.Label lblDiameter_Header;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label lblCircumference_Header;
        private System.Windows.Forms.Label lblCircumference;
        private System.Windows.Forms.Label lblSurfaceArea_Header;
        private System.Windows.Forms.Label lblSurfaceArea;
        private System.Windows.Forms.Label lblVolume_Header;
        private System.Windows.Forms.Label lblVolume;
    }
}

