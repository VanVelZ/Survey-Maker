namespace ZJV.SurveyMaker.Quizzer
{
    partial class Quizzer
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
            this.txtActivationCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuestionInfo = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rbtnAnswer1 = new System.Windows.Forms.RadioButton();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.rbtnAnswer2 = new System.Windows.Forms.RadioButton();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.rbtnAnswer3 = new System.Windows.Forms.RadioButton();
            this.lblAnswer4 = new System.Windows.Forms.Label();
            this.rbtnAnswer4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtActivationCode
            // 
            this.txtActivationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivationCode.Location = new System.Drawing.Point(282, 28);
            this.txtActivationCode.Name = "txtActivationCode";
            this.txtActivationCode.Size = new System.Drawing.Size(161, 29);
            this.txtActivationCode.TabIndex = 0;
            this.txtActivationCode.TextChanged += new System.EventHandler(this.txtActivationCode_TextChanged);
            this.txtActivationCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtActivationCode_KeyUp);
            this.txtActivationCode.Leave += new System.EventHandler(this.txtActivationCode_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter an Activation Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Question:";
            // 
            // lblQuestionInfo
            // 
            this.lblQuestionInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuestionInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionInfo.Location = new System.Drawing.Point(113, 87);
            this.lblQuestionInfo.Name = "lblQuestionInfo";
            this.lblQuestionInfo.Size = new System.Drawing.Size(330, 32);
            this.lblQuestionInfo.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(113, 338);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 61);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(282, 338);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 61);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rbtnAnswer1
            // 
            this.rbtnAnswer1.AutoSize = true;
            this.rbtnAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAnswer1.Location = new System.Drawing.Point(60, 150);
            this.rbtnAnswer1.Name = "rbtnAnswer1";
            this.rbtnAnswer1.Size = new System.Drawing.Size(14, 13);
            this.rbtnAnswer1.TabIndex = 6;
            this.rbtnAnswer1.TabStop = true;
            this.rbtnAnswer1.UseVisualStyleBackColor = true;
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer1.Location = new System.Drawing.Point(113, 143);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(330, 32);
            this.lblAnswer1.TabIndex = 7;
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer2.Location = new System.Drawing.Point(113, 189);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(330, 32);
            this.lblAnswer2.TabIndex = 9;
            // 
            // rbtnAnswer2
            // 
            this.rbtnAnswer2.AutoSize = true;
            this.rbtnAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAnswer2.Location = new System.Drawing.Point(60, 196);
            this.rbtnAnswer2.Name = "rbtnAnswer2";
            this.rbtnAnswer2.Size = new System.Drawing.Size(14, 13);
            this.rbtnAnswer2.TabIndex = 8;
            this.rbtnAnswer2.TabStop = true;
            this.rbtnAnswer2.UseVisualStyleBackColor = true;
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer3.Location = new System.Drawing.Point(113, 231);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(330, 32);
            this.lblAnswer3.TabIndex = 11;
            // 
            // rbtnAnswer3
            // 
            this.rbtnAnswer3.AutoSize = true;
            this.rbtnAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAnswer3.Location = new System.Drawing.Point(60, 238);
            this.rbtnAnswer3.Name = "rbtnAnswer3";
            this.rbtnAnswer3.Size = new System.Drawing.Size(14, 13);
            this.rbtnAnswer3.TabIndex = 10;
            this.rbtnAnswer3.TabStop = true;
            this.rbtnAnswer3.UseVisualStyleBackColor = true;
            // 
            // lblAnswer4
            // 
            this.lblAnswer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer4.Location = new System.Drawing.Point(113, 278);
            this.lblAnswer4.Name = "lblAnswer4";
            this.lblAnswer4.Size = new System.Drawing.Size(330, 32);
            this.lblAnswer4.TabIndex = 13;
            // 
            // rbtnAnswer4
            // 
            this.rbtnAnswer4.AutoSize = true;
            this.rbtnAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAnswer4.Location = new System.Drawing.Point(60, 285);
            this.rbtnAnswer4.Name = "rbtnAnswer4";
            this.rbtnAnswer4.Size = new System.Drawing.Size(14, 13);
            this.rbtnAnswer4.TabIndex = 12;
            this.rbtnAnswer4.TabStop = true;
            this.rbtnAnswer4.UseVisualStyleBackColor = true;
            // 
            // Quizzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(523, 411);
            this.Controls.Add(this.lblAnswer4);
            this.Controls.Add(this.rbtnAnswer4);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.rbtnAnswer3);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.rbtnAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.rbtnAnswer1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblQuestionInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtActivationCode);
            this.Name = "Quizzer";
            this.Text = "Quizzer";
            this.Load += new System.EventHandler(this.Quizzer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtActivationCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuestionInfo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rbtnAnswer1;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.RadioButton rbtnAnswer2;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.RadioButton rbtnAnswer3;
        private System.Windows.Forms.Label lblAnswer4;
        private System.Windows.Forms.RadioButton rbtnAnswer4;
    }
}

