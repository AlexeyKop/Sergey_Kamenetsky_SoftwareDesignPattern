using System;
using System.Text;
using System.Windows.Data;

namespace IDE
{
    public class MalbolgeAlphabet : IValueConverter
    {
        public static string input = "! \n\r%>&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}";
        public static string output = " \n\r5z]&gqtyfr$(we4{WP)H-Zn,[%\\3dL+Q;>U!pJS72FhOA1CB6v^=I_0/8|jsb9m<.TVac`uY*MK'X~xDl}REokN:#?G\"i@";
        
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in value.ToString())
            {
                var index = input.IndexOf(item);
                if (index != -1) { sb.Append(output[index]); }
                else { sb.Append(item); }
            }
            return sb.ToString();
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in value.ToString()) { sb.Append(input[output.IndexOf(item)]); }
            return sb.ToString();
        }
    }
}