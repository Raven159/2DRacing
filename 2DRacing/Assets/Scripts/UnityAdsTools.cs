using System;
using UnityEngine;
using UnityEngine.Advertisements;

namespace Tools
{
    internal class UnityAdsTools : MonoBehaviour, IAdsShower, IUnityAdsListener
    {
        private string _gameId = "123456789";
        private string _rewardPlace = "rewardAds";
        private string _interstitialPlace = "Interstitial_Android";

        private Action _callbackSuccessShowVideo;

        private void Start()
        {
            Advertisement.Initialize(_gameId, true);
        }

        public void ShowInterstitial()
        {
            _callbackSuccessShowVideo = null;
            Advertisement.Show(_interstitialPlace);
        }

        public void ShowVideo(Action successShow)
        {
            _callbackSuccessShowVideo = successShow;
            Advertisement.Show(_rewardPlace);
        }

        public void OnUnityAdsReady(string placementID)
        { 
            
        }

        public void OnUnityAdsDidStart(string placementId)
        { 
            
        }

        public void OnUnityAdsDidError(string message)
        {
            
        }

        public void OnUnityAdsDidFinish(string placamentId, ShowResult showResult)
        {
            if (showResult == ShowResult.Finished)
                _callbackSuccessShowVideo?.Invoke();
        }
    }
}
