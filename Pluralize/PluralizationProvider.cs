using System;
using System.Linq;

namespace Pluralize
{
    internal class PluralizationProvider
    {
        public static string Pluralize(string pluralizeBase, int number)
        {
            if (number < 0)
            {
                throw new InvalidOperationException();
            }
            var forms = pluralizeBase.Split('|');
            if (forms.Count() != 3)
            {
                throw new InvalidOperationException();
            }
            if (number == 1)
            {
                return forms[0];
            }
            if ((number % 10 == 2 || number % 10 == 3 || number % 10 == 4) && (Math.Floor((decimal)((number % 100) / 10)) != 1))
            {
                return forms[1];
            }
            return forms[2];
        }
    }
}