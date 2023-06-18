using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UIManager : MonoBehaviour
    {
        public Image image;
        public TMP_Text text;

        public Button button;

        [SerializeField] private Sprite _sprite;

        public Slider slider;


        private void Start()
        {
            //EditImage();
            //EditButton();
            
            EditSlider();
        }

        private void Update()
        {
            //image.fillAmount = Mathf.Lerp(image.fillAmount, 0, Time.deltaTime * .5f);
            
            //image.color = Color.Lerp(image.color, Color.blue, Time.deltaTime * .5f);
            
            image.color = Color.Lerp(image.color, 
                new Color(image.color.r, image.color.g, image.color.b, 0), 
                Time.deltaTime * .5f);
        }

        private void EditImage()
        {
            //image.sprite = _sprite;
            //image.fillAmount = .1f;
            
            //image.color = Color.blue;

            //image.color = new Color(1, 1, 1, 0);

        }

        private void EditButton()
        {
            button.interactable = false;

        }


        public void PressButton()
        {
            Debug.Log("Butona Basıldı");

            slider.value += 0.5f;
        }
        
        public void PressButton2()
        {
            Debug.Log("Butona Basıldı2");
        }

        private void EditSlider()
        {
            slider.minValue = 5;
            slider.maxValue = 10;

            slider.value = 7.5f;
        }
    }
}
