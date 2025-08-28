using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Extensions
{
    static class DateTimeExtensions
    {
        // com esse this nos parametros do metodo, ele referencia o proprio que o chama, ent ele precisa ser do tipo que é chamado
        // por exemplo: this DateTime nome do metodo -> variavelDateTime.ElapsedTime()
        public static string ElapsedTime(this DateTime thisObject)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObject);

            return duration.TotalHours < 24.0 
                ? duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " Hours" 
                : duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Days";
        }
    }
}
