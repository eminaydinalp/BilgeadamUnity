using System;
using UnityEngine;

namespace PlayerPrefOrnekleri
{
    public class PlayerPrefOrnek : MonoBehaviour
    {
        public int level;
        public string levelKey;

        public string name;
        public string nameKey;

        public float range;
        public string rangeKey;

        private void Start()
        {
            level = PlayerPrefs.GetInt(levelKey, 2);
            name = PlayerPrefs.GetString(nameKey, "Misafir");
            range = PlayerPrefs.GetFloat(rangeKey, 0.1f);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                LevelIncrease();
                ChangeName();
                ChangeRange();
            }
        }

        private void LevelIncrease()
        {
            level++;
            PlayerPrefs.SetInt(levelKey, level);
        }

        private void ChangeName()
        {
            name = "Ahmet";
            PlayerPrefs.SetString(nameKey, name);
        }
        
        private void ChangeRange()
        {
            range += 0.1f;
            PlayerPrefs.SetFloat(rangeKey, range);
        }
    }
}
