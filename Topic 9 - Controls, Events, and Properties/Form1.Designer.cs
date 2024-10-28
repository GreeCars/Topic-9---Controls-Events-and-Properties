namespace Topic_9___Controls__Events__and_Properties
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.imgCharacter = new System.Windows.Forms.PictureBox();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(107, 124);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Click Me";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(388, 187);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(180, 13);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Click on the Button or the Picturebox";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(452, 254);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            // 
            // imgCharacter
            // 
            this.imgCharacter.Image = ((System.Drawing.Image)(resources.GetObject("imgCharacter.Image")));
            this.imgCharacter.Location = new System.Drawing.Point(164, 227);
            this.imgCharacter.Name = "imgCharacter";
            this.imgCharacter.Size = new System.Drawing.Size(100, 111);
            this.imgCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgCharacter.TabIndex = 3;
            this.imgCharacter.TabStop = false;
            this.imgCharacter.Visible = false;
            this.imgCharacter.Click += new System.EventHandler(this.imgCharacter_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Enabled = false;
            this.btnQuit.Location = new System.Drawing.Point(292, 124);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.imgCharacter);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnSubmit);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = "Controls, Events, and Properties";
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox imgCharacter;
        private System.Windows.Forms.Button btnQuit;
    }
}

