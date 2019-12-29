using System;
using System.Collections.Generic;
using System.Text;
using BethanysPieShopStockApp.Model;
using Xamarin.Forms;

namespace BethanysPieShopStockApp.TemplateSelector
{
    public class PieTemplateSelector : DataTemplateSelector
    {
        public DataTemplate RegularPieTemplate { get; set; }

        public DataTemplate NotInStockTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Pie)item).InStock ? RegularPieTemplate : NotInStockTemplate;
        }
    }
}
