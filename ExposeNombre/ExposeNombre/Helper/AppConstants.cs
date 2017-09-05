using Xamarin.Forms;

namespace ExposeNombre.Helper
{
    public static class AppConstants
    {
        public static readonly Thickness PagePadding = GetPagePadding();

        private static Thickness GetPagePadding()
        {
            double topPadding;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    topPadding = 20;
                    break;
                case Device.Android:
                    topPadding = 100;
                    break;
                default:
                    topPadding = 0;
                    break;
                    
            }

            return new Thickness(5, topPadding, 5, 0);
        }
    }
}