using System.Collections.Generic;
using UnityEngine;

namespace ObjectPoolOrnekleri
{
    [System.Serializable]
    public class ObjectPoolItem
    {
        public string poolType;
        public GameObject prefab;
        public int poolSize = 10;
    }

    public class ObjectPooler : MonoBehaviour
    {
        public static ObjectPooler Instance;

        public List<ObjectPoolItem> objectPoolItems; // List of object types in the pool

        private Dictionary<GameObject, Queue<GameObject>> poolDictionary; // Dictionary to store the objects in the pool

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            poolDictionary = new Dictionary<GameObject, Queue<GameObject>>();

            // Create the objects for each prefab type in the pool
            foreach (ObjectPoolItem item in objectPoolItems)
            {
                Queue<GameObject> objectQueue = new Queue<GameObject>();

                for (int i = 0; i < item.poolSize; i++)
                {
                    GameObject obj = Instantiate(item.prefab);
                    obj.SetActive(false);
                    objectQueue.Enqueue(obj);
                }

                poolDictionary.Add(item.prefab, objectQueue);
            }
        }

        public GameObject GetObject(GameObject prefab, Vector3 position, Quaternion rotation)
        {
            // Find and return an inactive object of the specified prefab from the pool
            if (poolDictionary.ContainsKey(prefab))
            {
                Queue<GameObject> objectQueue = poolDictionary[prefab];

                if (objectQueue.Count > 0)
                {
                    Debug.Log("Kaç kere");
                    GameObject obj = objectQueue.Dequeue();
                    obj.SetActive(true);
                    obj.transform.position = position;
                    obj.transform.rotation = rotation;
                    return obj;
                }

                // If no inactive object is found, create a new one and add it to the pool
                GameObject newObj = Instantiate(prefab);
                newObj.transform.position = position;
                newObj.transform.rotation = rotation;
                return newObj;
            }

            Debug.LogWarning("Object prefab not found in pool: " + prefab.name);
            return null;
        }

        public void ReturnObject(GameObject obj)
        {
            // Deactivate the object and return it to its corresponding pool
            obj.SetActive(false);

            GameObject prefab = GetPrefabFromObject(obj);
            if (prefab != null && poolDictionary.ContainsKey(prefab))
            {
                Queue<GameObject> objectQueue = poolDictionary[prefab];
                objectQueue.Enqueue(obj);
            }
            else
            {
                Debug.LogWarning("Object's prefab not found in pool: " + obj.name);
            }
        }

        private GameObject GetPrefabFromObject(GameObject obj)
        {
            // Find the prefab associated with the object
            var prefabType = objectPoolItems.Find(item => item.poolType == obj.GetComponent<IPoolable>().PoolType);
            if (prefabType != null)
            {
                return prefabType.prefab;
            }

            return null;
        }
    }
}