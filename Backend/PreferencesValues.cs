using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euklido_algoritmas.Backend
{
    public class PreferencesValues
    {
        private static string preferencesAscending = "Zemas,Vidutinis,Aukstas,Auksciausias";
        private string[] preferences;
        public string[] GetPreferences
        {
            get { return preferences; }
        }

        public PreferencesValues()
        {
            preferences = preferencesAscending.Split(',');
        }
    }
}
