namespace assignment1_AndreiKazakov
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ExitButton = new System.Windows.Forms.Button();
            this.ShowMessageButton = new System.Windows.Forms.Button();
            this.ChangeLabelButton = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.ShowPictureButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(11, 220);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(126, 26);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ShowMessageButton
            // 
            this.ShowMessageButton.Location = new System.Drawing.Point(11, 191);
            this.ShowMessageButton.Name = "ShowMessageButton";
            this.ShowMessageButton.Size = new System.Drawing.Size(126, 23);
            this.ShowMessageButton.TabIndex = 2;
            this.ShowMessageButton.Text = "Show Message";
            this.ShowMessageButton.UseVisualStyleBackColor = true;
            this.ShowMessageButton.Click += new System.EventHandler(this.ShowMessageButton_Click);
            // 
            // ChangeLabelButton
            // 
            this.ChangeLabelButton.Location = new System.Drawing.Point(11, 162);
            this.ChangeLabelButton.Name = "ChangeLabelButton";
            this.ChangeLabelButton.Size = new System.Drawing.Size(126, 23);
            this.ChangeLabelButton.TabIndex = 3;
            this.ChangeLabelButton.Text = "Change Label";
            this.ChangeLabelButton.UseVisualStyleBackColor = true;
            this.ChangeLabelButton.Click += new System.EventHandler(this.ChangeLabelButton_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(13, 143);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(33, 13);
            this.Label.TabIndex = 4;
            this.Label.Text = "Label";
            // 
            // PictureBox
            // 
            this.PictureBox.ErrorImage = null;
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.InitialImage = null;
            this.PictureBox.Location = new System.Drawing.Point(11, 13);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(126, 113);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 5;
            this.PictureBox.TabStop = false;
            this.PictureBox.Visible = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // ShowPictureButton
            // 
            this.ShowPictureButton.Location = new System.Drawing.Point(11, 13);
            this.ShowPictureButton.Name = "ShowPictureButton";
            this.ShowPictureButton.Size = new System.Drawing.Size(126, 23);
            this.ShowPictureButton.TabIndex = 6;
            this.ShowPictureButton.Text = "Show Picture";
            this.ShowPictureButton.UseVisualStyleBackColor = true;
            this.ShowPictureButton.Click += new System.EventHandler(this.ShowPictureButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 258);
            this.Controls.Add(this.ShowPictureButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.ChangeLabelButton);
            this.Controls.Add(this.ShowMessageButton);
            this.Controls.Add(this.ExitButton);
            this.Name = "Form1";
            this.Text = "assignment1 Andrei Kazakov";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ShowMessageButton;
        private System.Windows.Forms.Button ChangeLabelButton;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button ShowPictureButton;
    }
}

