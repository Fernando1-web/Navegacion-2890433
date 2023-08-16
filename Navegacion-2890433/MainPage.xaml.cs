namespace Navegacion_2890433;

public partial class MainPage : ContentPage
{
	public MainPage()
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
    private void BtnCambio_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Cambio());
    }

    /// <summary>
    /// <createddate>2023/8/14</createddate>
    /// <company>INDEL</company>
    /// <lastmodificationdate>2023/8/14</lastmodificationdate>
    /// <lastmodificationdescription>este metodo permite calcular el area de un triangulo</lastmodificationdescription>
    /// <lastmodifierautor>Fernando Jose Majano Aguirre</lastmodifierautor>
    /// </summary>
    private void BtnSuperficie_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Superficie());
    }

    /// <summary>
    /// <createddate>2023/8/14</createddate>
    /// <company>INDEL</company>
    /// <lastmodificationdate>2023/8/14</lastmodificationdate>
    /// <lastmodificationdescription>este metodo permite los datos de un dinosaurio y luego imprimirlos</lastmodificationdescription>
    /// <lastmodifierautor>Fernando Jose Majano Aguirre</lastmodifierautor>
    /// </summary>
    private void BtnDinosaurio_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Dinosaurio());
    }

    /// <summary>
    /// <createddate>2023/8/14</createddate>
    /// <company>INDEL</company>
    /// <lastmodificationdate>2023/8/14</lastmodificationdate>
    /// <lastmodificationdescription>este metodo permite calcular y convertir de litros a galones y expresar su precio</lastmodificationdescription>
    /// <lastmodifierautor>Fernando Jose Majano Aguirre</lastmodifierautor>
    /// </summary>
    private void BtnGasolinera_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Gasolinera());
    }
}

