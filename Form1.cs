namespace CalculadoraWF;

public partial class Form1 : Form
{
    double num1, num2, resultado;
    bool parsedNum1 = false, parsedNum2 = false;

    public Form1()
    {
        InitializeComponent();

        // Estado inicial: btn_calcular bloqueado hasta que haya dos números válidos
        btn_calcular.Enabled = false;

        // Suscribir cambios de texto para validar en tiempo real
        txt_Num1.TextChanged += TxtInputs_TextChanged;
        txt_Num2.TextChanged += TxtInputs_TextChanged;

        // Asegurar estado inicial de variables
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

        // Habilitar btn_calcular solo si ambos son válidos
        btn_calcular.Enabled = parsedNum1 && parsedNum2;
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
        // Resultado NO se muestra aquí; se mostrará al pulsar btn_calcular
    }

    private void btn_Resta_Click(object sender, EventArgs e)
    {
        if (!EnsureInputsValid()) return;

        resultado = num1 - num2;
    }

    private void btn_Mult_Click(object sender, EventArgs e)
    {
        if (!EnsureInputsValid()) return;

        resultado = num1 * num2;
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
    }

    private void btn_Limpiar_Click(object sender, EventArgs e)
    {
        txt_Num1.Clear();
        txt_Num2.Clear();
        Result.Text = "0";

        // Reiniciar estado
        resultado = 0;
        parsedNum1 = parsedNum2 = false;
        btn_calcular.Enabled = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (!EnsureInputsValid()) return;

        resultado = Math.Pow(num1, num2);
    }

    private void btn_calcular_Click(object sender, EventArgs e)
    {
        // Mostrar el último resultado calculado
        Result.Text = resultado.ToString("F2");
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
}
