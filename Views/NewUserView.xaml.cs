
namespace Password_manager_lab.Views;

public partial class NewUserView : ContentPage
{
	public NewUserView()
	{
		InitializeComponent();
	}
    private async void OnSubmitButtonClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new PasswordListView());
    }

}