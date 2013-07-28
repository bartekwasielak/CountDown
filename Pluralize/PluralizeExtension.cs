using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pluralize
{
    public static class PluralizeExtension
    {
        public static string Pluralize(this string pluralizeBase, int number)
        {
            return PluralizationProvider.Pluralize(pluralizeBase, number);
        }
    }
}
