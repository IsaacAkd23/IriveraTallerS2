namespace IriveraTallerS2.Views;

public partial class vCalificaciones : ContentPage
{
	public vCalificaciones()
	{
		InitializeComponent();
	}


    private void btnCalcularNotaFinal_Clicked(object sender, EventArgs e)
    {
		double seguimiento1 = txtSeguimiento1 * 0.3();
        double examen1 = txtExamen1 * 0.2();
        double notaP1 = seguimiento1 + examen1 ;

        double seguimiento2 = txtSeguimiento1 * 0.2();
        double examen2 = txtExamen1 * 0.3();
        double notaP2 = seguimiento2 + examen2;
    }
}