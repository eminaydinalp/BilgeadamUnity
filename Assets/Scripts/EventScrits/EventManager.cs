using System;
using UnityEngine;
using UnityEngine.Events;

namespace EventScrits
{
    public static class EventManager
    {
        //public static Action OnGameFinish;
        //public static UnityAction OnGameFinish;
        
        public static event UnityAction OnGameFinish;

        public static void InvokeOnGameFinish()
        {
            // if (OnGameFinish != null)
            // {
            //     OnGameFinish.Invoke();
            // }
            
            OnGameFinish?.Invoke();
        }
        
        
    }
}
