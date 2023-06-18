using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Effects
{
    public class ParticleManager : MonoBehaviour
    {
        public GameObject fireParticle;
        public Transform cube;
        
        public float zOffset;
        public bool isFire;
        public float lerpSpeed;

        private float _time;

        public float waitTime;
        private void Update()
        {
            _time += Time.deltaTime;
            
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(fireParticle, cube.transform.position + Vector3.back * zOffset, Quaternion.identity);
                isFire = true;
                _time = 0;
            }

            if (isFire && _time > waitTime)
            {
                cube.transform.localScale = Vector3.Lerp(cube.transform.localScale, Vector3.zero, 
                    Time.deltaTime * lerpSpeed);
            }
            
        }
    }
}
