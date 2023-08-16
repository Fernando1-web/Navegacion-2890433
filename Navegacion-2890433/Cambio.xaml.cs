namespace Navegacion_2890433;

public partial class Cambio : ContentPage
{
	public Cambio()
	{
		InitializeComponent();
	}

    /// <summary>
    /// <createddate>2023/8/14</createddate>
    /// <company>INDEL</company>
    /// <lastmodificationdate>2023/8/14</lastmodificationdate>
    /// <lastmodificationdescription>este metodo permite calcular el cambio a un cliente</lastmodificationdescription>
    /// <lastmodifierautor>Fernando Jose Majano Aguirre</lastmodifierautor>
    /// </summary>
    private void BtnCalcular_Clicked(object sender, EventArgs e)
    {
        double Total, Pago, Cambio;

        Total = Convert.ToDouble(EntryTotal.Text);
        Pago = Convert.ToDouble(EntryPago.Text);

        Cambio = Pago - Total;

        LblResultado.Text = "$" + Cambio.ToString();
    }
}