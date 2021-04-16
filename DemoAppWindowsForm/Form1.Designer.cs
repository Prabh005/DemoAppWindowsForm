
namespace DemoAppWindowsForm
{
    partial class BtnRanNum
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
            this.lblRanNum1 = new System.Windows.Forms.Label();
            this.pbimage = new System.Windows.Forms.Button();
            this.PBPimg = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBPimg)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "Random Number";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRanNum1
            // 
            this.lblRanNum1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRanNum1.Location = new System.Drawing.Point(442, 50);
            this.lblRanNum1.Name = "lblRanNum1";
            this.lblRanNum1.Size = new System.Drawing.Size(269, 47);
            this.lblRanNum1.TabIndex = 3;
            // 
            // pbimage
            // 
            this.pbimage.Location = new System.Drawing.Point(486, 133);
            this.pbimage.Name = "pbimage";
            this.pbimage.Size = new System.Drawing.Size(163, 63);
            this.pbimage.TabIndex = 5;
            this.pbimage.Text = "chngimage";
            this.pbimage.UseVisualStyleBackColor = true;
            this.pbimage.Click += new System.EventHandler(this.pbimage_Click);
            // 
            // PBPimg
            // 
            this.PBPimg.BackgroundImage = global::DemoAppWindowsForm.Properties.Resources.c920_H2328866_hires_5980_DSC01768_Edit;
            this.PBPimg.Location = new System.Drawing.Point(452, 228);
            this.PBPimg.Name = "PBPimg";
            this.PBPimg.Size = new System.Drawing.Size(279, 132);
            this.PBPimg.TabIndex = 4;
            this.PBPimg.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 123);
            this.button2.TabIndex = 6;
            this.button2.Text = "change bhutton";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnRanNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pbimage);
            this.Controls.Add(this.PBPimg);
            this.Controls.Add(this.lblRanNum1);
            this.Controls.Add(this.button1);
            this.Name = "BtnRanNum";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PBPimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRanNum1;
        private System.Windows.Forms.PictureBox PBPimg;
        private System.Windows.Forms.Button pbimage;
        private System.Windows.Forms.Button button2;
    }
}

