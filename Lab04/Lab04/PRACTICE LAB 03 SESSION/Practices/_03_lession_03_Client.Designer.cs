
namespace Lab04
{
    partial class _03_lession_03_Client
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
            this.deuButton1 = new Lab04.DeuButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deuButton1
            // 
            this.deuButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.deuButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.deuButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deuButton1.BorderRadius = 5;
            this.deuButton1.BorderSize = 0;
            this.deuButton1.FlatAppearance.BorderSize = 0;
            this.deuButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deuButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deuButton1.ForeColor = System.Drawing.Color.Black;
            this.deuButton1.Location = new System.Drawing.Point(169, 115);
            this.deuButton1.Name = "deuButton1";
            this.deuButton1.Size = new System.Drawing.Size(463, 29);
            this.deuButton1.TabIndex = 37;
            this.deuButton1.Text = "Send message";
            this.deuButton1.TextColor = System.Drawing.Color.Black;
            this.deuButton1.UseVisualStyleBackColor = false;
            this.deuButton1.Click += new System.EventHandler(this.deuButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(364, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Form Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(328, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "LESSON 03";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.button1.Location = new System.Drawing.Point(169, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(463, 28);
            this.button1.TabIndex = 38;
            this.button1.Text = "QUIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _03_lession_03_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(800, 240);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deuButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "_03_lession_03_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " [PRACTICE LAB 03 SESSION] LESSION 3 CLIENT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DeuButton deuButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}