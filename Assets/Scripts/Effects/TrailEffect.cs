using System;
using UnityEngine;

namespace Effects
{
    public class TrailEffect : MonoBehaviour
    {
        private TrailRenderer _trailRenderer;

        private void Awake()
        {
            _trailRenderer = GetComponent<TrailRenderer>();
        }

        private void Start()
        {
            _trailRenderer.time = 4;
            _trailRenderer.emitting = false;
            _trailRenderer.autodestruct = true;
            _trailRenderer.startColor = Color.blue;
            _trailRenderer.endColor = Color.yellow;

            _trailRenderer.enabled = false;
            _trailRenderer.enabled = true;
        }
    }
}
