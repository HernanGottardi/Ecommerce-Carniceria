namespace formularios
{
    partial class FrmHistorial
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgv_facturaciones = new DataGridView();
            lb_tituloHistorial = new Label();
            lb_totalGanado = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_facturaciones).BeginInit();
            SuspendLayout();
            // 
            // dgv_facturaciones
            // 
            dgv_facturaciones.BackgroundColor = Color.Maroon;
            dgv_facturaciones.BorderStyle = BorderStyle.None;
            dgv_facturaciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Red;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_facturaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_facturaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Maroon;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Maroon;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_facturaciones.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_facturaciones.GridColor = Color.Maroon;
            dgv_facturaciones.Location = new Point(12, 113);
            dgv_facturaciones.Name = "dgv_facturaciones";
            dgv_facturaciones.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.SteelBlue;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_facturaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_facturaciones.RowHeadersVisible = false;
            dgv_facturaciones.RowHeadersWidth = 51;
            dgv_facturaciones.RowTemplate.Height = 29;
            dgv_facturaciones.Size = new Size(841, 188);
            dgv_facturaciones.TabIndex = 0;
            // 
            // lb_tituloHistorial
            // 
            lb_tituloHistorial.AutoSize = true;
            lb_tituloHistorial.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lb_tituloHistorial.Location = new Point(12, 47);
            lb_tituloHistorial.Name = "lb_tituloHistorial";
            lb_tituloHistorial.Size = new Size(501, 46);
            lb_tituloHistorial.TabIndex = 1;
            lb_tituloHistorial.Text = "HISTORIAL DE FACTURACIONES.";
            // 
            // lb_totalGanado
            // 
            lb_totalGanado.AutoSize = true;
            lb_totalGanado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_totalGanado.Location = new Point(12, 344);
            lb_totalGanado.Name = "lb_totalGanado";
            lb_totalGanado.Size = new Size(165, 28);
            lb_totalGanado.TabIndex = 2;
            lb_totalGanado.Text = "Total Recaudado: ";
            // 
            // FrmHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(865, 487);
            Controls.Add(lb_totalGanado);
            Controls.Add(lb_tituloHistorial);
            Controls.Add(dgv_facturaciones);
            ForeColor = Color.White;
            Name = "FrmHistorial";
            Text = "Historial Facturaciones";
            Load += FrmHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_facturaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_facturaciones;
        private Label lb_tituloHistorial;
        private Label lb_totalGanado;
    }
}