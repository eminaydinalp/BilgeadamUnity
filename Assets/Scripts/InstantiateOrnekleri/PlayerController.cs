using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace InstantiateOrnekleri
{
    public class PlayerController : MonoBehaviour
    {
        public Bullet bullet;
        private float gameTime;
        
        [SerializeField] private float repeatTime;
        private void Start()
        {
            //CreateBullet();
        }

        private void Update()
        {
            gameTime += Time.deltaTime;
            
            Debug.Log(gameTime);
            
            if (gameTime > repeatTime)
            {
                CreateBullet();

                gameTime = 0;
            }
        }

        public void CreateBullet()
        {
            Bullet newBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            
            newBullet.DestroyBullet();
        }
    }
}
