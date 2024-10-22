using MauiAppGuiaCurso.Anos;
using MauiAppGuiaCurso.Disciplinas;

namespace MauiAppGuiaCurso
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void primeiro_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Primeiro());
            }
            catch (Exception ex)
            {
                DisplayAlert("OPS!!", ex.Message, "OK");
            }
        }

        private void segundo_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Segundo());
            }
            catch (Exception ex)
            {
                DisplayAlert("OPS!!!", ex.Message, "OK");
            }

        }

        private void terceiro_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Terceiro());
            }
            catch (Exception ex) 
            {
                DisplayAlert("OPS!!!", ex.Message, "OK");
            }
        }
    }

}
