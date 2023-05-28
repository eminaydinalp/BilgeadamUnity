using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LifeCycle
{
    public class Player : MonoBehaviour
    {
        private void Awake()
        {
            Debug.Log("Awake");
        }

        private void OnEnable()
        {
            Debug.Log("On Enable");
        }

        private void Start()
        {
            Debug.Log("Start");
        }

        private void FixedUpdate()
        {
            Debug.Log("Fixed Update");
        }

        private void Update()
        {
            Debug.Log("Update");
        }

        private void LateUpdate()
        {
            Debug.Log("Late Update");
        }

        private void OnDisable()
        {
            Debug.Log("On Disable");
        }
    }
}

