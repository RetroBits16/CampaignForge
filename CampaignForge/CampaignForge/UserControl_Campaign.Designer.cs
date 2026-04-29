namespace CampaignForge
{
    partial class UserControl_Campaign
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btt_New_Campaign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btt_New_Campaign
            // 
            this.btt_New_Campaign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_New_Campaign.Location = new System.Drawing.Point(949, 19);
            this.btt_New_Campaign.Name = "btt_New_Campaign";
            this.btt_New_Campaign.Size = new System.Drawing.Size(94, 72);
            this.btt_New_Campaign.TabIndex = 0;
            this.btt_New_Campaign.Text = "New Campaign";
            this.btt_New_Campaign.UseVisualStyleBackColor = true;
            // 
            // UserControl_Campaign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Controls.Add(this.btt_New_Campaign);
            this.Name = "UserControl_Campaign";
            this.Size = new System.Drawing.Size(1067, 850);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btt_New_Campaign;
    }
}
