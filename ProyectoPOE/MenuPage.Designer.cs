namespace ProyectoPOE {
    partial class MenuPage {
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
            this.btn_VerEstadistica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_VerEstadistica
            // 
            this.btn_VerEstadistica.Location = new System.Drawing.Point(12, 108);
            this.btn_VerEstadistica.Name = "btn_VerEstadistica";
            this.btn_VerEstadistica.Size = new System.Drawing.Size(143, 34);
            this.btn_VerEstadistica.TabIndex = 0;
            this.btn_VerEstadistica.Text = "Ver Estadisticas";
            this.btn_VerEstadistica.UseVisualStyleBackColor = true;
            this.btn_VerEstadistica.Click += new System.EventHandler(this.btn_VerEstadistica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "VER ESTADISTICAS DE VENTAS";
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_VerEstadistica);
            this.Name = "MenuPage";
            this.Text = "MenuPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_VerEstadistica;
        private Label label1;
    }
}