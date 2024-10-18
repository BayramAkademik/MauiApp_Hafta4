namespace MauiApp_Hafta4;

public partial class UserDetails : ContentPage
{
	public UserDetails()
	{
		InitializeComponent();

		MyUser user = new MyUser()
		{
			Name = "Muhammed Talha",
			Surname = "Gök",
			Phone = "0535",
			Email = "muhammedtalha@mail.com",
			ImageLink = "https://media.licdn.com/dms/image/C4D03AQH2CaDWViRScQ/profile-displayphoto-shrink_800_800/0/1646655636028?e=2147483647&v=beta&t=Emsn9JNdnreIHlOq9O7Rnf91w5EFPjgavq8_nFzvroM",
			Adress = "Bartýn"
		};

		this.BindingContext = user;
	}

    private async void SelectImageClick(object sender, EventArgs e)
    {
		await DisplayActionSheet("Resim Seç:", "Ýptal", null, "Galeri", "Kamera");
    }

    private async void OkClicked(object sender, EventArgs e)
    {
		await DisplayAlert("Kaydetmeyi onayla",
			"Bilgiler kaydedilsin mi?",
			"Ok","Cancel" );
    }
}

class MyUser
{
	public string Name { get; set; }
	public string Surname { get; set; }
	public string Phone { get; set; }
	public string Email { get; set; }

	public string ImageLink { get; set; }

	public string Adress { get; set; }
}