namespace Navegacion_2890433;

public partial class Gasolinera : ContentPage
{
	public Gasolinera()
	{
		InitializeComponent();
	}

    /// <summary>
    /// <createddate>2023/8/14</createddate>
    /// <company>INDEL</company>
    /// <lastmodificationdate>2023/8/14</lastmodificationdate>
    /// <lastmodificationdescription>este metodo permite calcular y convertir de litros a galones y expresar su precio</lastmodificationdescription>
    /// <lastmodifierautor>Fernando Jose Majano Aguirre</lastmodifierautor>
    /// </summary>
    private void BtnCalcular_Clicked(object sender, EventArgs e)
    {
        double Litros;
        double PrecioLitro;

        Litros = Convert.ToDouble(Entry1.Text);
        PrecioLitro = Convert.ToDouble(Entry2.Text);

        double Galones = Litros * PrecioLitro * 3.78;

        LblTotal.Text = Galones.ToString();
    }
}