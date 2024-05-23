using UnityEngine;

namespace Tracker.watercan
{
    public class WaterCan : MonoBehaviour
    {
        [SerializeField] private Transform point1;
        [SerializeField] private Transform point2;
        [SerializeField] private Transform hose;
        [SerializeField] private GameObject water;
        [SerializeField] private WateringAudio wateringAudio;
    
        void Update()
        {
            if (point2.position.y < point1.position.y)
            {
                water.transform.position = hose.position;
                water.SetActive(true);
                wateringAudio.Sound(true);
            }
            else
            {
                water.SetActive(false);
                wateringAudio.Sound(false);
            }
        }
    }
}