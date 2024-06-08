using System.Runtime.CompilerServices;

namespace IriveraTallerS2.Views;

public partial class vCalificaciones : ContentPage
{
    
	public vCalificaciones()
	{
		InitializeComponent();
	}


    private void btnCalcularNotaFinal_Clicked(object sender, EventArgs e)
    {
        var seguimiento1 = double.Parse(txtSeguimiento1.Text)*0.3;
        var examen1 = double.Parse(txtExamen1.Text) * 0.2;
        var notaP1 = seguimiento1 + examen1;

        txtNota1.Text = notaP1.ToString("F2");

        var seguimiento2 = double.Parse(txtSeguimiento2.Text) * 0.3;
        var examen2 = double.Parse(txtExamen2.Text) * 0.2;
        var notaP2 = seguimiento2 + examen2;

        txtNota2.Text = notaP2.ToString("F2");

        var notaFinal = notaP1 + notaP2;
        txtNotaFinal.Text = notaFinal.ToString("F2");

        string fecha = dpFecha.Date.ToString();
        string estado = GetEstadoResultMessage(notaFinal);
        

        if (pkEstudiantes.SelectedIndex < 0)
            DisplayAlert("ERROR", "No se a seleccionado estudiante", "OK");
        else
        {
            string estudiantes = pkEstudiantes.Items[pkEstudiantes.SelectedIndex].ToString();
            DisplayAlert("CALIFICACION FINAL", "Estudiante: " + estudiantes +
           "\nFecha: " + fecha +
            "\nParcial N1: " + notaP1 +
            "\nParcial N2: " + notaP2 +
            "\nNOTA FINAL: " + notaFinal+
            "\n" + estado, "OK");
        }
        
        

    }
    private string GetEstadoResultMessage(double notaFinal)
    {
        if (notaFinal >= 0.1 && notaFinal <5)
        {
            return "Reprobado";
        }
        else if (notaFinal >= 5 && notaFinal <= 6.9)
        {
            return "Complementario";
        }
        else
        {
            return "Aprobado";
        }

    }
}