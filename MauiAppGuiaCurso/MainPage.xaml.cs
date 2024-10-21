namespace MauiAppGuiaCurso
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Pweb_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Pw());
            }
            catch (Exception ex)
            {
                DisplayAlert("OPS!!", ex.Message, "OK");
            }
        }
    }

}
