using System;
using UnityEngine;

namespace DefaultNamespace.MapScripts
{
    public class MapPresentor:MonoBehaviour
    {
        [SerializeField] KeyCode openMap = KeyCode.M;
        [SerializeField] private GameObject mapView;
        private void FixedUpdate()
        {
            if (Input.GetKeyDown(openMap))
            {
                if (mapView.activeSelf)
                    mapView.SetActive(false);
                else if(!mapView.activeSelf)
                    mapView.SetActive(true);
            }
        }
    }
}