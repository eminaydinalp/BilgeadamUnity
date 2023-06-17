using System;
using UnityEngine;

namespace Effects
{
    public class LineEffect : MonoBehaviour
    {
        [SerializeField] private LineRenderer _lineRenderer;

        public Transform[] cubes;
        private void Start()
        {
            // _lineRenderer.SetPosition(0, new Vector3(1, 2, 3));
            // _lineRenderer.SetPosition(1, new Vector3(3, 5, 9));
            
            
            // _lineRenderer.SetPosition(0, cubes[0].position);
            // _lineRenderer.SetPosition(1, cubes[1].position);
            //
            // _lineRenderer.positionCount++;
            //
            // _lineRenderer.SetPosition(2, cubes[2].position);

            _lineRenderer.positionCount = cubes.Length;
        }

        private void Update()
        {
            _lineRenderer.SetPosition(0, cubes[0].position);
            _lineRenderer.SetPosition(1, cubes[1].position);

            
            _lineRenderer.SetPosition(2, cubes[2].position);
        }
    }
}
