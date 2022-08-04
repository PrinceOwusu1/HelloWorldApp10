
namespace HelloWorldApp10
{
    partial class HelloWorldForm
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
            this.HelloWorldLable = new System.Windows.Forms.Label();
            this.ClickMeBotton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HelloWorldLable
            // 
            this.HelloWorldLable.AutoSize = true;
            this.HelloWorldLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloWorldLable.Location = new System.Drawing.Point(161, 36);
            this.HelloWorldLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HelloWorldLable.Name = "HelloWorldLable";
            this.HelloWorldLable.Size = new System.Drawing.Size(311, 37);
            this.HelloWorldLable.TabIndex = 0;
            this.HelloWorldLable.Text = "Show Message Here";
            // 
            // ClickMeBotton
            // 
            this.ClickMeBotton.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClickMeBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickMeBotton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClickMeBotton.Location = new System.Drawing.Point(386, 185);
            this.ClickMeBotton.Name = "ClickMeBotton";
            this.ClickMeBotton.Size = new System.Drawing.Size(272, 61);
            this.ClickMeBotton.TabIndex = 1;
            this.ClickMeBotton.Text = "CLICK ME";
            this.ClickMeBotton.UseVisualStyleBackColor = false;
            this.ClickMeBotton.Click += new System.EventHandler(this.ClickMeBotton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.SystemColors.InfoText;
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.exitbutton.Location = new System.Drawing.Point(70, 185);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(272, 61);
            this.exitbutton.TabIndex = 2;
            this.exitbutton.Text = "EXIT";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(246, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 3;
            // 
            // HelloWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 341);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.ClickMeBotton);
            this.Controls.Add(this.HelloWorldLable);
            this.Font = new System.Drawing.Font("Matura MT Script Capitals", 8.25F, ((System.Drawing.FontStyle)((((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HelloWorldForm";
            this.Text = "Hello World App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloWorldLable;
        private System.Windows.Forms.Button ClickMeBotton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

