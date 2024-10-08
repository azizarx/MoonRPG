using System;
using System.Collections;
using UnityEngine;

namespace WorldTime
{
    public class WorldTime : MonoBehaviour
    {

        public event EventHandler<TimeSpan> WorldTimeChanged;

        [SerializeField]
        private float _dayLength;

        private TimeSpan _currentTime;
        private float _minuteLength => _dayLength / WorldTimeConstants.MinuntesInDay;

        private void Start()
        {
            //start  day from the middle
            //_currentTime = TimeSpan.FromHours(8);
            StartCoroutine(AddMinute());
        }

        private IEnumerator AddMinute()
        {
            _currentTime += TimeSpan.FromMinutes(1);
            WorldTimeChanged?.Invoke(this, _currentTime);
            yield return new WaitForSeconds(_minuteLength);
            StartCoroutine(AddMinute());
        }
    }
}
