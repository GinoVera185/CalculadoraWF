namespace CalculadoraWF;

public partial class Form1 : Form
{
    public double num1, num2, resultado;
    private bool parsedNum1 = false, parsedNum2 = false;
    public string nombreArchivo = "Historial.dat";
    public string operacion;

    public Form1()
    {
        InitializeComponent();

        txt_Num1.TextChanged += TxtInputs_TextChanged;
        txt_Num2.TextChanged += TxtInputs_TextChanged;


        UpdateInputs();
    }

    private void TxtInputs_TextChanged(object? sender, EventArgs e)
    {
        UpdateInputs();
    }

    private void UpdateInputs()
    {
        parsedNum1 = double.TryParse(txt_Num1.Text, out num1);
        parsedNum2 = double.TryParse(txt_Num2.Text, out num2);
    }

    private void txt_Num1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (!double.TryParse(txt_Num1.Text, out num1))
        {
            e.Cancel = true;
            MessageBox.Show("Tipo de dato incorrecto");
        }
        else
        {
            parsedNum1 = true;
            UpdateInputs();
        }
    }

    private void txt_Num2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (!double.TryParse(txt_Num2.Text, out num2))
        {
            e.Cancel = true;
            MessageBox.Show("Tipo de dato incorrecto");
        }
        else
        {
            parsedNum2 = true;
            UpdateInputs();
        }
    }

    private void btn_Suma_Click(object sender, EventArgs e)
    {

        if (!EnsureInputsValid()) return;

        resultado = num1 + num2;

        Result.Text = resultado.ToString("F2");

        operacion = num1.ToString() + " + " + num2.ToString();

        Archivo.GuardarOperacion(operacion, nombreArchivo);
    }

    private void btn_Resta_Click(object sender, EventArgs e)
    {
        if (!EnsureInputsValid()) return;

        resultado = num1 - num2;

        Result.Text = resultado.ToString("F2");

        operacion = num1.ToString() + " - " + num2.ToString();

        Archivo.GuardarOperacion(operacion, nombreArchivo);
    }

    private void btn_Mult_Click(object sender, EventArgs e)
    {
        if (!EnsureInputsValid()) return;

        resultado = num1 * num2;

        Result.Text = resultado.ToString("F2");

        operacion = num1.ToString() + " * " + num2.ToString();
        Archivo.GuardarOperacion(operacion, nombreArchivo);
    }

    private void btn_Dividir_Click(object sender, EventArgs e)
    {
        if (!EnsureInputsValid()) return;

        if (num2 == 0)
        {
            MessageBox.Show("No es posible dividir por cero");
            return;
        }

        resultado = num1 / num2;

        Result.Text = resultado.ToString("F2");

        operacion = num1.ToString() + " / " + num2.ToString();
        Archivo.GuardarOperacion(operacion, nombreArchivo);
    }

    private void btn_Limpiar_Click(object sender, EventArgs e)
    {
        txt_Num1.Clear();
        txt_Num2.Clear();
        Result.Text = "0";

        // Reiniciar estado
        resultado = 0;
        parsedNum1 = parsedNum2 = false;
        btn_residuo.Enabled = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (!EnsureInputsValid()) return;

        resultado = Math.Pow(num1, num2);

        Result.Text = resultado.ToString("F2");

        operacion = num1.ToString() + "pow(" + num2.ToString() + ")";
        Archivo.GuardarOperacion(operacion, nombreArchivo);
    }

    private void btn_calcular_Click(object sender, EventArgs e)
    {
        if (!EnsureInputsValid()) return;
        if (num2 == 0)
        {
            MessageBox.Show("No se puede calcular el residuo con divisor cero.");
            return;
        }
        resultado = num1 % num2;

        Result.Text = resultado.ToString("F2");

        operacion = num1.ToString() + "mod(" + num2.ToString() + ")";
        Archivo.GuardarOperacion(operacion, nombreArchivo);
    }

    // Comprueba que ambos inputs sean válidos; muestra mensaje si no lo son.
    private bool EnsureInputsValid()
    {
        // Actualizar parseos por si no se han actualizado
        UpdateInputs();

        if (!parsedNum1 || !parsedNum2)
        {
            MessageBox.Show("Introduzca ambos números válidos antes de realizar la operación.");
            return false;
        }

        return true;
    }

    private void btn_HistorialOp_Click(object sender, EventArgs e)
    {
        Form2 frm = new Form2();
        frm.Show();
    }
}
