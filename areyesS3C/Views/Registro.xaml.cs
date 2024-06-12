namespace areyesS3C.Views;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

	private void btnGuardar_Clicked(object sender, EventArgs e)
	{
		string usuario = txtUsuario.Text;
		string contrasena = txtContrasena.Text;
		DisplayAlert("Alerta", "USUARIO GUARDADO", "OK");
		Navigation.PushAsync(new login(usuario, contrasena));
	}
}