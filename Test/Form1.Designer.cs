namespace Test
{
    partial class frmDragon
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
            this.lblPlayer = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtDragon = new System.Windows.Forms.TextBox();
            this.lblDragon = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(20, 12);
            this.lblPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(90, 18);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Player name";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlayerName.Location = new System.Drawing.Point(24, 49);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlayerName.Multiline = true;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(844, 91);
            this.txtPlayerName.TabIndex = 1;
            // 
            // txtDragon
            // 
            this.txtDragon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDragon.Location = new System.Drawing.Point(24, 206);
            this.txtDragon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDragon.Multiline = true;
            this.txtDragon.Name = "txtDragon";
            this.txtDragon.Size = new System.Drawing.Size(844, 91);
            this.txtDragon.TabIndex = 3;
            // 
            // lblDragon
            // 
            this.lblDragon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDragon.AutoSize = true;
            this.lblDragon.Location = new System.Drawing.Point(20, 168);
            this.lblDragon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDragon.Name = "lblDragon";
            this.lblDragon.Size = new System.Drawing.Size(101, 18);
            this.lblDragon.TabIndex = 2;
            this.lblDragon.Text = "Dragon Name";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(24, 322);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(846, 122);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtbOut
            // 
            this.rtbOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOut.Location = new System.Drawing.Point(24, 466);
            this.rtbOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.Size = new System.Drawing.Size(844, 131);
            this.rtbOut.TabIndex = 5;
            this.rtbOut.Text = "";
            // 
            // frmDragon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 624);
            this.Controls.Add(this.rtbOut);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDragon);
            this.Controls.Add(this.lblDragon);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblPlayer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDragon";
            this.Text = "Player and Dragon name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.TextBox txtDragon;
        private System.Windows.Forms.Label lblDragon;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtbOut;
    }
}

