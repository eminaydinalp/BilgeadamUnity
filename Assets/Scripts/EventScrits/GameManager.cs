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

        public void GameStart()
        {
            Debug.Log("Oyun Başladı");
        }
        
        public void GameStart(int score)
        {
            Debug.Log("Oyun Başladı ve scorumuz : " + score);
        }
    }
}
