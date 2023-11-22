using TMPro;
using UnityEngine;

namespace Resourses.DistanceMeter
{
    public class DistanceMeterUIView : MonoBehaviour, IView
    {
        [SerializeField] private TextMeshProUGUI _distanceText;

        public void OnChangedDistance(float distance)
        {
            _distanceText.text = distance.ToString();
        }
    }
}