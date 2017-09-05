using System;
using Xamarin.Forms;

namespace ExposeNombre
{
    public class ExposeNombreCode : ContentPage
    {
        public ExposeNombreCode()
        {
            Title = "ExposeNombre";
            var txtNum = new Entry {Placeholder =  "nombre", Text = "2"};
            var txtExp = new Entry {Placeholder = "exposant", Text = "3"};
            var btnExpose = new Button {Text = "Expose C"};
            var lblResult = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold
            };

            //btnExpose.Clicked += btnExpose_Clicked;
            btnExpose.Clicked += (sender, e) =>
            {
                var num = double.Parse(txtNum.Text);
                var exp = double.Parse(txtExp.Text);
                var result = Math.Pow(exp, num);
                var info = $"Résultat : {result}";
                lblResult.Text = info;
            };

            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = {txtNum, txtExp, btnExpose, lblResult }
                
            };
        }
    }
}
