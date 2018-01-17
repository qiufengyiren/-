namespace 项目经理评分
{
    partial class FrmJudge
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
            this.btnout = new System.Windows.Forms.Button();
            this.btnRating = new System.Windows.Forms.Button();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtEvaluation = new System.Windows.Forms.TextBox();
            this.lblEvaluation = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnout
            // 
            this.btnout.Location = new System.Drawing.Point(318, 402);
            this.btnout.Margin = new System.Windows.Forms.Padding(4);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(100, 29);
            this.btnout.TabIndex = 15;
            this.btnout.Text = "取消";
            this.btnout.UseVisualStyleBackColor = true;
            // 
            // btnRating
            // 
            this.btnRating.Location = new System.Drawing.Point(129, 402);
            this.btnRating.Margin = new System.Windows.Forms.Padding(4);
            this.btnRating.Name = "btnRating";
            this.btnRating.Size = new System.Drawing.Size(100, 29);
            this.btnRating.TabIndex = 14;
            this.btnRating.Text = "评价";
            this.btnRating.UseVisualStyleBackColor = true;
            this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(158, 321);
            this.txtRating.Margin = new System.Windows.Forms.Padding(4);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(209, 25);
            this.txtRating.TabIndex = 13;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(66, 324);
            this.lblRating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(37, 15);
            this.lblRating.TabIndex = 12;
            this.lblRating.Text = "评分";
            // 
            // txtEvaluation
            // 
            this.txtEvaluation.Location = new System.Drawing.Point(158, 115);
            this.txtEvaluation.Margin = new System.Windows.Forms.Padding(4);
            this.txtEvaluation.Multiline = true;
            this.txtEvaluation.Name = "txtEvaluation";
            this.txtEvaluation.Size = new System.Drawing.Size(209, 168);
            this.txtEvaluation.TabIndex = 11;
            // 
            // lblEvaluation
            // 
            this.lblEvaluation.AutoSize = true;
            this.lblEvaluation.Location = new System.Drawing.Point(66, 140);
            this.lblEvaluation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEvaluation.Name = "lblEvaluation";
            this.lblEvaluation.Size = new System.Drawing.Size(37, 15);
            this.lblEvaluation.TabIndex = 10;
            this.lblEvaluation.Text = "评价";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 54);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(209, 25);
            this.txtName.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 54);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 15);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "员工姓名";
            // 
            // FrmJudge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 455);
            this.Controls.Add(this.btnout);
            this.Controls.Add(this.btnRating);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.txtEvaluation);
            this.Controls.Add(this.lblEvaluation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "FrmJudge";
            this.Text = "评分";
            this.Load += new System.EventHandler(this.FrmJudge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnout;
        private System.Windows.Forms.Button btnRating;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtEvaluation;
        private System.Windows.Forms.Label lblEvaluation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}