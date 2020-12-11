using System;
using System.Collections.Generic;
using People.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace People.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TShirtPage : ContentPage
    {
        public TShirtPage()
        {
            InitializeComponent();
        }

        public void ButtonClicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            App.PersonRepo.AddNewTShirt(newNames.Text, newGenders.Text, newTShirtSizes.Text, newDateOfOrders.Text, newTShirtColors.Text, newShipping_Addresses.Text);
            statusMessage.Text = App.PersonRepo.StatusMessage;
        }

        public void GetButtonClicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            List<tshirt> people = App.PersonRepo.GetProductInfo();
            tshirtList.ItemsSource = people;

           
        }
    }
}