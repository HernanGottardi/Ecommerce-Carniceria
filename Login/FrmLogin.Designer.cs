namespace FrmLogin
{
    partial class FrmLogin
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
            txb_mail = new TextBox();
            txb_contraseña = new TextBox();
            label1 = new Label();
            btn_Cliente = new Button();
            label3 = new Label();
            btn_Vendedor = new Button();
            btn_ingresoManual = new Button();
            lb_automatizar = new Label();
            SuspendLayout();
            // 
            // txb_mail
            // 
            txb_mail.Location = new Point(167, 104);
            txb_mail.Name = "txb_mail";
            txb_mail.PlaceholderText = "Ejemplo: hernan@gmail.com";
            txb_mail.Size = new Size(462, 27);
            txb_mail.TabIndex = 0;
            // 
            // txb_contraseña
            // 
            txb_contraseña.Location = new Point(167, 231);
            txb_contraseña.Name = "txb_contraseña";
            txb_contraseña.PasswordChar = '*';
            txb_contraseña.PlaceholderText = "********";
            txb_contraseña.Size = new Size(462, 27);
            txb_contraseña.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(167, 43);
            label1.Name = "label1";
            label1.Size = new Size(84, 46);
            label1.TabIndex = 2;
            label1.Text = "Mail";
            // 
            // btn_Cliente
            // 
            btn_Cliente.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cliente.Location = new Point(475, 371);
            btn_Cliente.Name = "btn_Cliente";
            btn_Cliente.Size = new Size(134, 47);
            btn_Cliente.TabIndex = 4;
            btn_Cliente.Text = "Cliente";
            btn_Cliente.UseVisualStyleBackColor = true;
            btn_Cliente.Click += btn_Cliente_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(167, 172);
            label3.Name = "label3";
            label3.Size = new Size(189, 46);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // btn_Vendedor
            // 
            btn_Vendedor.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Vendedor.Location = new Point(615, 371);
            btn_Vendedor.Name = "btn_Vendedor";
            btn_Vendedor.Size = new Size(134, 47);
            btn_Vendedor.TabIndex = 6;
            btn_Vendedor.Text = "Vendedor";
            btn_Vendedor.UseVisualStyleBackColor = true;
            btn_Vendedor.Click += btn_Vendedor_Click;
            // 
            // btn_ingresoManual
            // 
            btn_ingresoManual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ingresoManual.Location = new Point(167, 284);
            btn_ingresoManual.Name = "btn_ingresoManual";
            btn_ingresoManual.Size = new Size(102, 39);
            btn_ingresoManual.TabIndex = 7;
            btn_ingresoManual.Text = "Ingresar";
            btn_ingresoManual.UseVisualStyleBackColor = true;
            btn_ingresoManual.Click += btn_ingresoManual_Click;
            // 
            // lb_automatizar
            // 
            lb_automatizar.AutoSize = true;
            lb_automatizar.Location = new Point(475, 331);
            lb_automatizar.Name = "lb_automatizar";
            lb_automatizar.Size = new Size(186, 20);
            lb_automatizar.TabIndex = 8;
            lb_automatizar.Text = "Ingresar automaticamente:";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_automatizar);
            Controls.Add(btn_ingresoManual);
            Controls.Add(btn_Vendedor);
            Controls.Add(label3);
            Controls.Add(btn_Cliente);
            Controls.Add(label1);
            Controls.Add(txb_contraseña);
            Controls.Add(txb_mail);
            Name = "FrmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_mail;
        private TextBox txb_contraseña;
        private Label label1;
        private Button btn_Cliente;
        private Label label3;
        private Button btn_Vendedor;
        private Button btn_ingresoManual;
        private Label lb_automatizar;
    }
}