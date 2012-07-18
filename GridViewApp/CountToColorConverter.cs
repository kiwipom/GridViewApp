using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace GridViewApp
{
    public class CountToColorConverter : IValueConverter
    {
        private static readonly App ThisApp = (App)Application.Current;
        private static Brush _emptyColorBrush;
        private static Brush _fullColorBrush;

        private static Brush FullColorBrush
        {
            get { return _fullColorBrush ?? (_fullColorBrush = new SolidColorBrush(Colors.LightBlue)); }
        }

        private static Brush EmptyColorBrush
        {
            get { return _emptyColorBrush ?? (_emptyColorBrush = new SolidColorBrush(Colors.PaleVioletRed)); }
        }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var group = value as IEnumerable<object>;
            if (group == null)
                return EmptyColorBrush;

            return group.Any() ? FullColorBrush : EmptyColorBrush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
