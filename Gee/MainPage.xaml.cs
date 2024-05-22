namespace Gee
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                Main.Text = $"Hello {count} time";
            else
                Main.Text = $"Hello {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
