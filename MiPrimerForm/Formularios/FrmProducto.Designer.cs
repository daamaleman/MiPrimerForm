namespace MiPrimerForm.Formularios
{
    partial class FrmProducto
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
            this.tabRegistros = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabGrid = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.cbIva = new System.Windows.Forms.CheckBox();
            this.tabRegistros.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabRegistros
            // 
            this.tabRegistros.Controls.Add(this.tabGeneral);
            this.tabRegistros.Controls.Add(this.tabGrid);
            this.tabRegistros.Location = new System.Drawing.Point(29, 35);
            this.tabRegistros.Name = "tabRegistros";
            this.tabRegistros.SelectedIndex = 0;
            this.tabRegistros.Size = new System.Drawing.Size(732, 380);
            this.tabRegistros.TabIndex = 5;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.cbIva);
            this.tabGeneral.Controls.Add(this.tbPrice);
            this.tabGeneral.Controls.Add(this.label3);
            this.tabGeneral.Controls.Add(this.tbName);
            this.tabGeneral.Controls.Add(this.label2);
            this.tabGeneral.Controls.Add(this.tbCode);
            this.tabGeneral.Controls.Add(this.label1);
            this.tabGeneral.Location = new System.Drawing.Point(4, 25);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(724, 351);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "Datos del Producto";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tabGrid
            // 
            this.tabGrid.Location = new System.Drawing.Point(4, 25);
            this.tabGrid.Name = "tabGrid";
            this.tabGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrid.Size = new System.Drawing.Size(724, 351);
            this.tabGrid.TabIndex = 1;
            this.tabGrid.Text = "Registris Guardados";
            this.tabGrid.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(103, 41);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(150, 22);
            this.tbCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(103, 90);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(335, 22);
            this.tbName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(103, 145);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(150, 22);
            this.tbPrice.TabIndex = 3;
            // 
            // cbIva
            // 
            this.cbIva.AutoSize = true;
            this.cbIva.Location = new System.Drawing.Point(103, 198);
            this.cbIva.Name = "cbIva";
            this.cbIva.Size = new System.Drawing.Size(91, 20);
            this.cbIva.TabIndex = 4;
            this.cbIva.Text = "Aplica IVA";
            this.cbIva.UseVisualStyleBackColor = true;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabRegistros);
            this.Name = "FrmProducto";
            this.Text = "Producto";
            this.tabRegistros.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRegistros;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabGrid;
        private System.Windows.Forms.CheckBox cbIva;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label1;
    }
}