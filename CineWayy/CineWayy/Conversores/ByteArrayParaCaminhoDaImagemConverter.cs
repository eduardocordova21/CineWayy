using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace CineWayy.Conversores
{
    class ByteArrayParaCaminhoDaImagemConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            byte[] bytes;

            var assembly = GetType().GetTypeInfo().Assembly;

            var stream = assembly.GetFile((string)value);
            
            using (var memoryStream = new MemoryStream())
            {
                stream.CopyToAsync(memoryStream);
                bytes = memoryStream.ToArray();
            }

            return ImageSource.FromStream(() => new MemoryStream(bytes));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
