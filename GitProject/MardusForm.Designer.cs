namespace GitProject
{
    partial class MardusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MardusForm));
            this.Answers = new System.Windows.Forms.TextBox();
            this.ranAmount = new System.Windows.Forms.TextBox();
            this.Bio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Answers
            // 
            this.Answers.Location = new System.Drawing.Point(147, 115);
            this.Answers.Multiline = true;
            this.Answers.Name = "Answers";
            this.Answers.ReadOnly = true;
            this.Answers.Size = new System.Drawing.Size(59, 49);
            this.Answers.TabIndex = 11;
            // 
            // ranAmount
            // 
            this.ranAmount.Location = new System.Drawing.Point(12, 115);
            this.ranAmount.Name = "ranAmount";
            this.ranAmount.Size = new System.Drawing.Size(75, 20);
            this.ranAmount.TabIndex = 9;
            // 
            // Bio
            // 
            this.Bio.Location = new System.Drawing.Point(12, 12);
            this.Bio.Multiline = true;
            this.Bio.Name = "Bio";
            this.Bio.Size = new System.Drawing.Size(221, 76);
            this.Bio.TabIndex = 7;
            this.Bio.Text = resources.GetString("Bio.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Please enter amount of random numbers";
            // 
            // MardusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 177);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Answers);
            this.Controls.Add(this.ranAmount);
            this.Controls.Add(this.Bio);
            this.Controls.Add(this.button1);
            this.Name = "MardusForm";
            this.Text = "MardusForm";
            this.Load += new System.EventHandler(this.MardusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Answers;
        private System.Windows.Forms.TextBox ranAmount;
        private System.Windows.Forms.TextBox Bio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}