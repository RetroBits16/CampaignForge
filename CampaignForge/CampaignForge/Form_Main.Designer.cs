namespace CampaignForge
{
    partial class Form_Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btt_Campaign = new System.Windows.Forms.Button();
            this.btt_System = new System.Windows.Forms.Button();
            this.Box_Main = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btt_Campaign
            // 
            this.btt_Campaign.Location = new System.Drawing.Point(64, 30);
            this.btt_Campaign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btt_Campaign.Name = "btt_Campaign";
            this.btt_Campaign.Size = new System.Drawing.Size(100, 28);
            this.btt_Campaign.TabIndex = 0;
            this.btt_Campaign.Text = "Campaign";
            this.btt_Campaign.UseVisualStyleBackColor = true;
            this.btt_Campaign.Click += new System.EventHandler(this.btt_Campaign_Click);
            // 
            // btt_System
            // 
            this.btt_System.Location = new System.Drawing.Point(252, 30);
            this.btt_System.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btt_System.Name = "btt_System";
            this.btt_System.Size = new System.Drawing.Size(100, 28);
            this.btt_System.TabIndex = 1;
            this.btt_System.Text = "System";
            this.btt_System.UseVisualStyleBackColor = true;
            this.btt_System.Click += new System.EventHandler(this.btt_System_Click);
            // 
            // Box_Main
            // 
            this.Box_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Box_Main.Location = new System.Drawing.Point(0, 62);
            this.Box_Main.Margin = new System.Windows.Forms.Padding(0);
            this.Box_Main.Name = "Box_Main";
            this.Box_Main.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Box_Main.Size = new System.Drawing.Size(1067, 850);
            this.Box_Main.TabIndex = 2;
            this.Box_Main.TabStop = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(1067, 912);
            this.Controls.Add(this.Box_Main);
            this.Controls.Add(this.btt_System);
            this.Controls.Add(this.btt_Campaign);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(901, 949);
            this.Name = "Form_Main";
            this.Text = "Campaign Forge";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btt_Campaign;
        private System.Windows.Forms.Button btt_System;
        private System.Windows.Forms.GroupBox Box_Main;
    }
}

