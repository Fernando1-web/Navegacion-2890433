namespace Navegacion_2890433;

public partial class Superficie : ContentPage
{
	public Superficie()
	{
		InitializeComponent();
	}


    /// <summary>
    /// <createddate>2023/8/14</createddate>
    /// <company>INDEL</company>
    /// <lastmodificationdate>2023/8/14</lastmodificationdate>
    /// <lastmodificationdescription>este metodo permite calcular el area de un triangulo</lastmodificationdescription>
    /// <lastmodifierautor>Fernando Jose Majano Aguirre</lastmodifierautor>
    /// </summary>
    private void Calcular_Clicked(object sender, EventArgs e)
    {
        int Base1, Altura1, Area;

        Base1 = Convert.ToInt32(Base.Text);
        Altura1 = Convert.ToInt32(Altura.Text);

        Area = (Base1 * Altura1) / 2;

        LblArea.Text = "El resultado es :" + Area + "cm^2";
    }
}