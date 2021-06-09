using System;

namespace Tools
{
    internal interface IReadOnlySubscriptionAction
    {
        void SubscribeOnChange(Action subscriptionAtion);
        void UnSubscriptionOnChange(Action unsubscriptionAction);
    }
}
