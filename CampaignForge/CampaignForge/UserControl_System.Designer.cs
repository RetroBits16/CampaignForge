namespace CampaignForge
{
    partial class UserControl_System
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
            this.btt_New_System = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btt_New_System
            // 
            this.btt_New_System.Location = new System.Drawing.Point(967, 14);
            this.btt_New_System.Name = "btt_New_System";
            this.btt_New_System.Size = new System.Drawing.Size(82, 66);
            this.btt_New_System.TabIndex = 0;
            this.btt_New_System.Text = "New System";
            this.btt_New_System.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 90);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1029, 491);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // UserControl_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btt_New_System);
            this.Name = "UserControl_System";
            this.Size = new System.Drawing.Size(1067, 850);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btt_New_System;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
