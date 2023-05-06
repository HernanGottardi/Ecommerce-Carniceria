namespace formularios
{
    partial class FrmAgregarCorte
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_AgregarCorte = new Label();
            txb_agregarCorteNuevo = new TextBox();
            btn_cancelar = new Button();
            btn_aceptar = new Button();
            SuspendLayout();
            // 
            // lb_AgregarCorte
            // 
            lb_AgregarCorte.AutoSize = true;
            lb_AgregarCorte.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lb_AgregarCorte.Location = new Point(174, 122);
            lb_AgregarCorte.Name = "lb_AgregarCorte";
            lb_AgregarCorte.Size = new Size(419, 41);
            lb_AgregarCorte.TabIndex = 0;
            lb_AgregarCorte.Text = "Agregar nuevo corte de carne:";
            // 
            // txb_agregarCorteNuevo
            // 
            txb_agregarCorteNuevo.Location = new Point(158, 210);
            txb_agregarCorteNuevo.Name = "txb_agregarCorteNuevo";
            txb_agregarCorteNuevo.PlaceholderText = "Ingresar aqui...";
            txb_agregarCorteNuevo.Size = new Size(453, 27);
            txb_agregarCorteNuevo.TabIndex = 1;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(441, 283);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(170, 60);
            btn_cancelar.TabIndex = 2;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(158, 283);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(170, 60);
            btn_aceptar.TabIndex = 3;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click_1;
            // 
            // FrmAgregarCorte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_aceptar);
            Controls.Add(btn_cancelar);
            Controls.Add(txb_agregarCorteNuevo);
            Controls.Add(lb_AgregarCorte);
            Name = "FrmAgregarCorte";
            Text = "Agregar Corte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_AgregarCorte;
        private TextBox txb_agregarCorteNuevo;
        private Button btn_cancelar;
        private Button btn_aceptar;
    }
}