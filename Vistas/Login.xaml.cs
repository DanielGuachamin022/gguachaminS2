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
			Navigation.PushAsync(new Elementos(usuario));
		}
		else{
			DisplayAlert("Alerta", "Usuario o contraseņa incorrectos", "Cerrar");
			TxtContrasena.Text = "";
			TxtUsuario.Text = "";
		}
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Registro());
    }
}