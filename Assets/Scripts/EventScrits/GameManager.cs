using System;
using UnityEngine;

namespace EventScrits
{
    public class GameManager : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                EventManager.InvokeOnGameFinish();
            }
        }
    }
}
