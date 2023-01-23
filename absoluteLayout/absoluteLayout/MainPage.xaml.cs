using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace absoluteLayout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var layout = new AbsoluteLayout();
            Content = layout;
            var aquBox = new BoxView { Color = Color.Gray };
            layout.Children.Add(aquBox, new Rectangle(0, 0, 1, 1), AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(layout, new Rectangle(0.5, 0.1, 100, 100));
            AbsoluteLayout.SetLayoutFlags(layout, AbsoluteLayoutFlags.HeightProportional);
        }
    }
}

