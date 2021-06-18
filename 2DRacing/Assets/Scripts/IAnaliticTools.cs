using System.Collections.Generic;

namespace Profile.Analitic
{
    internal interface IAnaliticTools
    {
        void SendMasseger(string alias, IDictionary<string, object> eventData = null);
    }
}
