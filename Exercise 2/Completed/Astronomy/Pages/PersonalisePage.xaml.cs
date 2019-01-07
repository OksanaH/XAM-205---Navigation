using Xamarin.Forms;
using System;

namespace Astronomy.Pages
{
    public partial class PersonalisePage : ContentPage
    {
        public PersonalisePage()
        {
            InitializeComponent();

            btnSave.Clicked += BtnSaveClicked;
            btnCancel.Clicked += BtnCancelClicked;
        }

        async void BtnCancelClicked(object sender, EventArgs e)
        {
           await  Navigation.PopModalAsync();
        }

        async void BtnSaveClicked(object sender, EventArgs e)
        {
            Application.Current.Properties["Name"] = entryName.Text;
            Application.Current.Properties["Icon"] = pickerIcon.SelectedItem;
            await Application.Current.SavePropertiesAsync();
            await this.Navigation.PopModalAsync();
        }
    }
}