namespace gguachaminS2.Vistas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
		string usuario = "uisrael";
		string contrasena = "12345";

		if(usuario == TxtUsuario.Text && contrasena == TxtContrasena.Text) {
			Navigation.PushAsync(new Elementos());
		}
		else{
			DisplayAlert("Alerta", "Usuario o contraseña incorrectos", "Cerrar");
			TxtContrasena.Text = "";
			TxtUsuario.Text = "";
		}
    }
}