using UnityEngine;

namespace ObjectPoolOrnekleri
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private GameObject[] bullets;

        private void Start()
        {
            InvokeRepeating(nameof(CreateBullet), 0, 0.1f);
        }

        private void CreateBullet()
        {
            //Instantiate(bullet);
            ObjectPooler.Instance.GetObject(bullets[Random.Range(0, bullets.Length)], transform.position, 
                Quaternion.Euler(90, 0, 0));
        }
    }
}

