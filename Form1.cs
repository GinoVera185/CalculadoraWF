namespace CalculadoraWF;

public partial class Form1 : Form
{
    float num1, num2, resultado;
    public Form1()
    {
        InitializeComponent();
    }

    private void txt_Num1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (!float.TryParse(txt_Num1.Text, out num1))
        {
            e.Cancel = true;
            MessageBox.Show("Tipo de dato incorrecto");
        }
    }

    private void txt_Num2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (!float.TryParse(txt_Num2.Text, out num2))
        {
            e.Cancel = true;
            MessageBox.Show("Tipo de dato incorrecto");
        }
    }

    private void btn_Suma_Click(object sender, EventArgs e)
    {
        resultado = num1 + num2;
        Result.Text = resultado.ToString("F2");
    }

    private void btn_Resta_Click(object sender, EventArgs e)
    {
        resultado = num1 - num2;
        Result.Text = resultado.ToString("F2");
    }

    private void btn_Mult_Click(object sender, EventArgs e)
    {
        resultado = num1 * num2;
        Result.Text = resultado.ToString("F2");
    }

    private void btn_Dividir_Click(object sender, EventArgs e)
    {
        resultado = num1 / num2;
        Result.Text = resultado.ToString("F2");
    }

    private void btn_Limpiar_Click(object sender, EventArgs e)
    {
        txt_Num1.Clear();
        txt_Num2.Clear();
        Result.Text = "0";
    }
}
