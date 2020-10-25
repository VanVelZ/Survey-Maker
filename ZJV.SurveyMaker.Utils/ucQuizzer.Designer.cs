namespace ZJV.SurveyMaker.Utils
{
    partial class ucQuizzer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.rbtnAnswer1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer1.Location = new System.Drawing.Point(68, 0);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(330, 32);
            this.lblAnswer1.TabIndex = 9;
            // 
            // rbtnAnswer1
            // 
            this.rbtnAnswer1.AutoSize = true;
            this.rbtnAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAnswer1.Location = new System.Drawing.Point(15, 7);
            this.rbtnAnswer1.Name = "rbtnAnswer1";
            this.rbtnAnswer1.Size = new System.Drawing.Size(14, 13);
            this.rbtnAnswer1.TabIndex = 8;
            this.rbtnAnswer1.TabStop = true;
            this.rbtnAnswer1.UseVisualStyleBackColor = true;
            this.rbtnAnswer1.CheckedChanged += new System.EventHandler(this.rbtnAnswer1_CheckedChanged);
            // 
            // ucQuizzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.rbtnAnswer1);
            this.Name = "ucQuizzer";
            this.Size = new System.Drawing.Size(416, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.RadioButton rbtnAnswer1;
    }
}
