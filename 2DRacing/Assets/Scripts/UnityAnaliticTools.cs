using System.Collections.Generic;
using UnityEngine.Analytics;

namespace Profile.Analitic
{
    internal class UnityAnaliticTools : IAnaliticTools
    {
        public void SendMasseger(string alias, IDictionary<string, object> eventData = null)
        {
            if (eventData == null)
                eventData = new Dictionary<string, object>();
            Analytics.CustomEvent(alias, eventData);
        }
    }
}
