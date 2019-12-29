using BethanysPieShopStockApp.Model;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace BethanysPieShopStockApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public Pie CherryPie { get; set; }

        public MainPage()
        {
            InitializeComponent();

            CherryPie = new Pie
            {
                Id = 1,
                PieName = "Cherry Pie",
                Price = 20
            };

            this.BindingContext = CherryPie;

            //Example of code based databinding
            //SetBinding(pie, "PieName", NameEntry);
            //SetBinding(pie, "Price", PriceEntry);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            CherryPie.Price++;
        }

        /* Given a source object, a string containing a target element name
         * and an entry control to bind to, setup and apply a databinding
         * between source and target */

        private void SetBinding(Pie pie, string path, Entry entry)
        {
            // Setup databinding for pie object to....
            Binding binding = new Binding();

            // 1) Specify source object and property
            binding.Source = pie;
            binding.Path = path;

            // 2) Specify target object and property
            entry.SetBinding(Entry.TextProperty, binding);
        }
    }
}