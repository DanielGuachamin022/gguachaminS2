using static System.Runtime.InteropServices.JavaScript.JSType;

namespace gguachaminS2.Vistas;

public partial class Elementos : ContentPage
{
	public Elementos()
	{
		InitializeComponent();
	}

    private void btnPicker_Clicked(object sender, EventArgs e)
    {
        if(pkCiudades.SelectedIndex == -1) {
            DisplayAlert("Alerta", "Seleccione un país!", "Cerrar");
        }
        else {
            string dato = pkCiudades.Items[pkCiudades.SelectedIndex].ToString();
            lblDatoPicker.Text = "La ciudad seleccionado es " + dato;
        }
    }

    private void btnFechas_Clicked(object sender, EventArgs e)
    {
        string fecha = dpFecha.Date.ToString();
        lblDatoPicker.Text= "La fecha seleccionada es " + fecha;
    }
}