using System.Collections.Generic;
using UnityEngine;

namespace ObjectPoolOrnekleri
{
    [System.Serializable]
    public class ObjectPoolItemWithList
    {
        public GameObject prefab;
        public int poolSize = 10;
    }

    public class ObjectPoolerWithList : MonoBehaviour
    {
        public static ObjectPoolerWithList Instance;
    
        public List<ObjectPoolItemWithList> objectPoolItems;  // List of object types in the pool

        private Dictionary<GameObject, List<GameObject>> poolDictionary;  // Dictionary to store the objects in the pool

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            poolDictionary = new Dictionary<GameObject, List<GameObject>>();

            // Create the objects for each prefab type in the pool
            foreach (ObjectPoolItemWithList item in objectPoolItems)
            {
                List<GameObject> objectList = new List<GameObject>();

                for (int i = 0; i < item.poolSize; i++)
                {
                    GameObject obj = Instantiate<GameObject>(item.prefab);
                    obj.SetActive(false);
                    objectList.Add(obj);
                }

                poolDictionary.Add(item.prefab, objectList);
            }
        }

        public GameObject GetObject(GameObject prefab, Vector3 position, Quaternion rotation)
        {
            // Find and return an inactive object of the specified prefab from the pool
            if (poolDictionary.ContainsKey(prefab))
            {
                List<GameObject> objectList = poolDictionary[prefab];

                foreach (GameObject obj in objectList)
                {
                    if (!obj.activeInHierarchy)
                    {
                        obj.SetActive(true);
                        obj.transform.position = position;
                        obj.transform.rotation = rotation;
                        return obj;
                    }
                }

                // If no inactive object is found, create a new one and add it to the pool
                GameObject newObj = Instantiate(prefab);
                objectList.Add(newObj);
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
        }
    }
}