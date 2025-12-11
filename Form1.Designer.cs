namespace CalculadoraWF;

partial class Form1
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
        label1 = new Label();
        label2 = new Label();
        txt_Num1 = new TextBox();
        txt_Num2 = new TextBox();
        label3 = new Label();
        btn_Suma = new Button();
        btn_Resta = new Button();
        btn_Mult = new Button();
        btn_Dividir = new Button();
        Result = new Label();
        btn_Limpiar = new Button();
        btn_potencia = new Button();
        btn_residuo = new Button();
        btn_HistorialOp = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(12, 28);
        label1.Name = "label1";
        label1.Size = new Size(148, 33);
        label1.TabIndex = 0;
        label1.Text = "Numero1:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(12, 61);
        label2.Name = "label2";
        label2.Size = new Size(148, 33);
        label2.TabIndex = 1;
        label2.Text = "Numero2:";
        // 
        // txt_Num1
        // 
        txt_Num1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txt_Num1.Location = new Point(166, 22);
        txt_Num1.Name = "txt_Num1";
        txt_Num1.Size = new Size(187, 34);
        txt_Num1.TabIndex = 1;
        txt_Num1.Validating += txt_Num1_Validating;
        // 
        // txt_Num2
        // 
        txt_Num2.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txt_Num2.Location = new Point(166, 67);
        txt_Num2.Name = "txt_Num2";
        txt_Num2.Size = new Size(187, 34);
        txt_Num2.TabIndex = 2;
        txt_Num2.Validating += txt_Num2_Validating;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.Location = new Point(12, 114);
        label3.Name = "label3";
        label3.Size = new Size(160, 33);
        label3.TabIndex = 4;
        label3.Text = "Resultado:";
        // 
        // btn_Suma
        // 
        btn_Suma.BackColor = Color.PaleVioletRed;
        btn_Suma.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btn_Suma.ForeColor = Color.Black;
        btn_Suma.Location = new Point(23, 171);
        btn_Suma.Name = "btn_Suma";
        btn_Suma.Size = new Size(107, 49);
        btn_Suma.TabIndex = 5;
        btn_Suma.Text = "Suma(+)";
        btn_Suma.UseVisualStyleBackColor = false;
        btn_Suma.Click += btn_Suma_Click;
        // 
        // btn_Resta
        // 
        btn_Resta.BackColor = Color.PaleVioletRed;
        btn_Resta.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btn_Resta.Location = new Point(23, 235);
        btn_Resta.Name = "btn_Resta";
        btn_Resta.Size = new Size(107, 49);
        btn_Resta.TabIndex = 6;
        btn_Resta.Text = "Resta(-)";
        btn_Resta.UseVisualStyleBackColor = false;
        btn_Resta.Click += btn_Resta_Click;
        // 
        // btn_Mult
        // 
        btn_Mult.BackColor = Color.PaleVioletRed;
        btn_Mult.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btn_Mult.Location = new Point(178, 171);
        btn_Mult.Name = "btn_Mult";
        btn_Mult.Size = new Size(173, 49);
        btn_Mult.TabIndex = 7;
        btn_Mult.Text = "Multiplicación(*)";
        btn_Mult.UseVisualStyleBackColor = false;
        btn_Mult.Click += btn_Mult_Click;
        // 
        // btn_Dividir
        // 
        btn_Dividir.BackColor = Color.PaleVioletRed;
        btn_Dividir.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btn_Dividir.Location = new Point(178, 235);
        btn_Dividir.Name = "btn_Dividir";
        btn_Dividir.Size = new Size(137, 49);
        btn_Dividir.TabIndex = 8;
        btn_Dividir.Text = "División(/)";
        btn_Dividir.UseVisualStyleBackColor = false;
        btn_Dividir.Click += btn_Dividir_Click;
        // 
        // Result
        // 
        Result.AutoSize = true;
        Result.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Result.Location = new Point(178, 118);
        Result.Name = "Result";
        Result.Size = new Size(25, 26);
        Result.TabIndex = 9;
        Result.Text = "0";
        // 
        // btn_Limpiar
        // 
        btn_Limpiar.BackColor = Color.SlateBlue;
        btn_Limpiar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btn_Limpiar.Location = new Point(181, 372);
        btn_Limpiar.Name = "btn_Limpiar";
        btn_Limpiar.Size = new Size(134, 44);
        btn_Limpiar.TabIndex = 10;
        btn_Limpiar.Text = "Limpiar";
        btn_Limpiar.UseVisualStyleBackColor = false;
        btn_Limpiar.Click += btn_Limpiar_Click;
        // 
        // btn_potencia
        // 
        btn_potencia.BackColor = Color.PaleVioletRed;
        btn_potencia.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btn_potencia.Location = new Point(23, 305);
        btn_potencia.Name = "btn_potencia";
        btn_potencia.Size = new Size(137, 49);
        btn_potencia.TabIndex = 11;
        btn_potencia.Text = "Potencia(^)";
        btn_potencia.UseVisualStyleBackColor = false;
        btn_potencia.Click += button1_Click;
        // 
        // btn_residuo
        // 
        btn_residuo.BackColor = Color.PaleVioletRed;
        btn_residuo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btn_residuo.Location = new Point(178, 305);
        btn_residuo.Name = "btn_residuo";
        btn_residuo.Size = new Size(137, 49);
        btn_residuo.TabIndex = 12;
        btn_residuo.Text = "mod (%)";
        btn_residuo.UseVisualStyleBackColor = false;
        btn_residuo.Click += btn_calcular_Click;
        // 
        // btn_HistorialOp
        // 
        btn_HistorialOp.BackColor = Color.SlateBlue;
        btn_HistorialOp.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btn_HistorialOp.Location = new Point(23, 372);
        btn_HistorialOp.Name = "btn_HistorialOp";
        btn_HistorialOp.Size = new Size(134, 44);
        btn_HistorialOp.TabIndex = 13;
        btn_HistorialOp.Text = "Historial";
        btn_HistorialOp.UseVisualStyleBackColor = false;
        btn_HistorialOp.Click += btn_HistorialOp_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Thistle;
        ClientSize = new Size(365, 428);
        Controls.Add(btn_HistorialOp);
        Controls.Add(btn_residuo);
        Controls.Add(btn_potencia);
        Controls.Add(btn_Limpiar);
        Controls.Add(Result);
        Controls.Add(btn_Dividir);
        Controls.Add(btn_Mult);
        Controls.Add(btn_Resta);
        Controls.Add(btn_Suma);
        Controls.Add(label3);
        Controls.Add(txt_Num2);
        Controls.Add(txt_Num1);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Calculadora";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox txt_Num1;
    private TextBox txt_Num2;
    private Label label3;
    private Button btn_Suma;
    private Button btn_Resta;
    private Button btn_Mult;
    private Button btn_Dividir;
    private Label Result;
    private Button btn_Limpiar;
    private Button btn_potencia;
    private Button btn_residuo;
    private Button btn_HistorialOp;
}
