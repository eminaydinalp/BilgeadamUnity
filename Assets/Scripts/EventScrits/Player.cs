using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EventScrits
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float jumpPower;

        private void OnEnable()
        {
            EventManager.OnGameFinish += Jump;
        }

        private void OnDisable()
        {
            EventManager.OnGameFinish -= Jump;
        }


        private void Jump()
        {
            transform.position += Vector3.up * jumpPower;
        }
    }
}

