﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bitpapr.Automax.Core.Model;

namespace Bitpapr.Automax.ValueConverters
{
    /// <summary>
    /// Converts an <see cref="Employee.Active"/> flag to a string
    /// </summary>
    public class ActiveToStringConverter : BaseValueConverter<ActiveToStringConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool active)
            {
                if (active)
                    return "Ativo";
                else
                    return "Desativado";
            }

            return null;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
