using System;
using Xamarin.Forms;

namespace ExposeNombre
{
    public partial class ExposeNombreXaml : ContentPage
    {
        public ExposeNombreXaml()
        {
            InitializeComponent();
        }

        private void TxtNum_OnFocused(object sender, FocusEventArgs e)
        {
            
        }

        private void TxtExp_OnFocused(object sender, FocusEventArgs e)
        {
            
        }

        private void BtnExpose_OnClicked(object sender, EventArgs e)
        {
            var num = double.Parse(txtNum.Text);
            var exp = double.Parse(txtExp.Text);
            var result = Math.Pow(exp, num);
            var info = $"Résultat : {result}";
            lblResult.IsVisible = true;
            lblResult.Text = info;
        }
    }
}