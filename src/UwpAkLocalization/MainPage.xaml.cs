using System.Globalization;
using System.Threading.Tasks;
using Microsoft.Windows.ApplicationModel.Resources;
using Windows.Globalization;
using AKSoftware.Localization.MultiLanguages;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;
using AKSoftware.Localization.MultiLanguages.UWP;
using Microsoft.Extensions.DependencyInjection;

namespace UwpAkLocalization
{
    public sealed partial class MainPage : Page
    {
        public ILanguageContainerService Localization { get; private set; }
        public MainPage()
        {
            this.InitializeComponent();
            SuppressPageAnimation();
            Localization = ((IServiceProviderHost)Application.Current).ServiceProvider.GetService<ILanguageContainerService>();
        }

        private void SuppressPageAnimation()
        {
            var transitionCollection = new TransitionCollection();
            var theme = new NavigationThemeTransition
            {
                DefaultNavigationTransitionInfo = new SuppressNavigationTransitionInfo()
            };

            transitionCollection.Add(theme);
            Transitions = transitionCollection;
        }

        private void SetLanguage(object sender, RoutedEventArgs e)
        {
            var language = ((Button) sender).Tag.ToString();
            var culture = CultureInfo.GetCultureInfo(language);
            Localization.SetLanguage(culture);
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
