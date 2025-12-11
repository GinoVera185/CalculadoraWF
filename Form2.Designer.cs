namespace CalculadoraWF
{
    partial class Form2
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
            bt_anterior = new Button();
            bt_siguiente = new Button();
            lbl_Mostrar = new Label();
            SuspendLayout();
            // 
            // bt_anterior
            // 
            bt_anterior.Location = new Point(22, 20);
            bt_anterior.Name = "bt_anterior";
            bt_anterior.Size = new Size(140, 33);
            bt_anterior.TabIndex = 1;
            bt_anterior.Text = "Anterior";
            bt_anterior.UseVisualStyleBackColor = true;
            // 
            // bt_siguiente
            // 
            bt_siguiente.Location = new Point(179, 20);
            bt_siguiente.Name = "bt_siguiente";
            bt_siguiente.Size = new Size(140, 33);
            bt_siguiente.TabIndex = 2;
            bt_siguiente.Text = "Siguiente";
            bt_siguiente.UseVisualStyleBackColor = true;
            // 
            // lbl_Mostrar
            // 
            lbl_Mostrar.AutoSize = true;
            lbl_Mostrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Mostrar.Location = new Point(38, 85);
            lbl_Mostrar.Name = "lbl_Mostrar";
            lbl_Mostrar.Size = new Size(76, 31);
            lbl_Mostrar.TabIndex = 3;
            lbl_Mostrar.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(503, 204);
            Controls.Add(lbl_Mostrar);
            Controls.Add(bt_siguiente);
            Controls.Add(bt_anterior);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bt_anterior;
        private Button bt_siguiente;
        private Label lbl_Mostrar;
    }
}