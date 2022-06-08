
namespace Lab04
{
    partial class _04_lession_04_app
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.customTextBox1 = new Lab04.CustomTextBox();
            this.deuButton1 = new Lab04.DeuButton();
            this.deuButton2 = new Lab04.DeuButton();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(43, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.BackColor = System.Drawing.Color.Black;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(12, 55);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1304, 650);
            this.webView21.TabIndex = 5;
            this.webView21.ZoomFactor = 1D;
            // 
            // customTextBox1
            // 
            this.customTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.customTextBox1.BorderRadius = 0;
            this.customTextBox1.BorderSize = 2;
            this.customTextBox1.Location = new System.Drawing.Point(106, 12);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.Size = new System.Drawing.Size(1128, 22);
            this.customTextBox1.TabIndex = 24;
            this.customTextBox1.Texts = "";
            this.customTextBox1.UnderlinedStyle = true;
            // 
            // deuButton1
            // 
            this.deuButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.deuButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.deuButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deuButton1.BorderRadius = 10;
            this.deuButton1.BorderSize = 0;
            this.deuButton1.FlatAppearance.BorderSize = 0;
            this.deuButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deuButton1.ForeColor = System.Drawing.Color.Black;
            this.deuButton1.Location = new System.Drawing.Point(1241, 6);
            this.deuButton1.Name = "deuButton1";
            this.deuButton1.Size = new System.Drawing.Size(66, 37);
            this.deuButton1.TabIndex = 26;
            this.deuButton1.Text = "Search";
            this.deuButton1.TextColor = System.Drawing.Color.Black;
            this.deuButton1.UseVisualStyleBackColor = false;
            this.deuButton1.Click += new System.EventHandler(this.deuButton1_Click);
            // 
            // deuButton2
            // 
            this.deuButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.deuButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.deuButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deuButton2.BorderRadius = 15;
            this.deuButton2.BorderSize = 0;
            this.deuButton2.FlatAppearance.BorderSize = 0;
            this.deuButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deuButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deuButton2.ForeColor = System.Drawing.Color.Black;
            this.deuButton2.Location = new System.Drawing.Point(72, 10);
            this.deuButton2.Name = "deuButton2";
            this.deuButton2.Size = new System.Drawing.Size(27, 28);
            this.deuButton2.TabIndex = 27;
            this.deuButton2.Text = "R";
            this.deuButton2.TextColor = System.Drawing.Color.Black;
            this.deuButton2.UseVisualStyleBackColor = false;
            this.deuButton2.Click += new System.EventHandler(this.deuButton2_Click);
            // 
            // _04_lession_04_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1328, 717);
            this.Controls.Add(this.deuButton2);
            this.Controls.Add(this.deuButton1);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "_04_lession_04_app";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[PRACTICE LAB 04 SESSION] LESSION 4 APPLICATION";
            this.Load += new System.EventHandler(this._04_lession_04_app_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private CustomTextBox customTextBox1;
        private DeuButton deuButton1;
        private DeuButton deuButton2;
    }
}