﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using XOutput.Devices.XInput;

namespace XOutput.UI.Converters
{
    /// <summary>
    /// Converts decimals to round integer string.
    /// Cannot be used backwards.
    /// </summary>
    public class DecimalToStringConverter : IValueConverter
    {
        /// <summary>
        /// Converts decimals to round integer string.
        /// </summary>
        /// <param name="value">decimal value</param>
        /// <param name="targetType">Ignored</param>
        /// <param name="parameter">Ignored</param>
        /// <param name="culture">Ignored</param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            decimal? d = value as decimal?;
            if (d.HasValue)
                return d.Value.ToString("0");
            else
                return "";
        }

        /// <summary>
        /// Intentionally not implemented.
        /// </summary>
        /// <param name="value">Ignored</param>
        /// <param name="targetType">Ignored</param>
        /// <param name="parameter">Ignored</param>
        /// <param name="culture">Ignored</param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
