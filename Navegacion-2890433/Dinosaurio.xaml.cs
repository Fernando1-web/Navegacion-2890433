namespace Navegacion_2890433;

public partial class Dinosaurio : ContentPage
{
	public Dinosaurio()
	{
		InitializeComponent();
	}

    /// <summary>
    /// <createddate>2023/8/14</createddate>
    /// <company>INDEL</company>
    /// <lastmodificationdate>2023/8/14</lastmodificationdate>
    /// <lastmodificationdescription>este metodo permite los datos de un dinosaurio y luego imprimirlos</lastmodificationdescription>
    /// <lastmodifierautor>Fernando Jose Majano Aguirre</lastmodifierautor>
    /// </summary>
    private void BtnDatos_Clicked(object sender, EventArgs e)
    {
        string Dino1;
        int Kgs;
        int Mts;
        double Lbs;
        int Cms;

        Dino1 = Dino.Text;
        Kgs = Convert.ToInt32(Peso.Text);
        Mts = Convert.ToInt32(Altura.Text);

        Lbs = Kgs * 2.2;
        Cms = Mts * 100;

        LblDatos.Text = Dino1;
        LblPeso.Text = Lbs.ToString() + " " + "Libras";
        LblAltura.Text = Cms.ToString() + " " + "Centimetros";
    }
}