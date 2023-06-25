using UnityEngine;

namespace InputOrnekleri
{
    public class InputManager : MonoBehaviour
    {
        public float horizontal;
        public float vertical;
        
        
        private void Update()
        {
            //GetMouseButtonDown();

            //GetMouseButton();
            
            //GetMouseButtonUp();
            
            // Tekerleğin hareketi 
            
            //ScrollWheel();

           //GetKey();

           //GetTouch();

           //GetAxis();
        }

        private void GetMouseButtonDown()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Sol click basıldı");
            }
            if (Input.GetMouseButtonDown(1))
            {
                Debug.Log("sağ click basıldı");
            }
            
            if (Input.GetMouseButtonDown(2))
            {
                Debug.Log("Orta click basıldı");
            }
            
            if (Input.GetMouseButtonDown(3))
            {
                Debug.Log("3");
            }
            
            if (Input.GetMouseButtonDown(4))
            {
                Debug.Log("4");
            }
            if (Input.GetMouseButtonDown(5))
            {
                Debug.Log("5");
            }
        }

        private void GetMouseButton()
        {
            if (Input.GetMouseButton(0))
            {
                Debug.Log("Sol click basılmımaya devam ediyor");
            }
            if (Input.GetMouseButton(1))
            {
                Debug.Log("sağ click basılmımaya devam ediyor");
            }
            
            if (Input.GetMouseButton(2))
            {
                Debug.Log("Orta click basılmımaya devam ediyor");
            }
            
            if (Input.GetMouseButton(3))
            {
                Debug.Log("3 basılmımaya devam ediyor");
            }
            
            if (Input.GetMouseButton(4))
            {
                Debug.Log("4 basılmımaya devam ediyor");
            }
            if (Input.GetMouseButton(5))
            {
                Debug.Log("5 basılmımaya devam ediyor");
            }
        }

        private void GetMouseButtonUp()
        {
            if (Input.GetMouseButtonUp(0))
            {
                Debug.Log("Sol click bırakıldı");
            }
            if (Input.GetMouseButtonUp(1))
            {
                Debug.Log("sağ click bırakıldı");
            }
            
            if (Input.GetMouseButtonUp(2))
            {
                Debug.Log("Orta click bırakıldı");
            }
            
            if (Input.GetMouseButtonUp(3))
            {
                Debug.Log("3 bırakıldı");
            }
            
            if (Input.GetMouseButtonUp(4))
            {
                Debug.Log("4 bırakıldı");
            }
            if (Input.GetMouseButtonUp(5))
            {
                Debug.Log("5 bırakıldı");
            }
        }

        private void ScrollWheel()
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                Debug.Log("Yukarı");
            }
            
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                Debug.Log("Aşağı");
            }
        }

        private void GetKey()
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Debug.Log("Bir kere basıldı");
            }
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Bir kere basıldı");
            }
            
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                Debug.Log("Bir kere bırakıldı");
            }
            
            if (Input.GetKey(KeyCode.Space))
            {
                Debug.Log("Basılmaya devam ediyor");
            }
        }

        private void GetTouch()
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)
                {
                    Debug.Log("İlk dokunma algılandı");
                }
                if (touch.phase == TouchPhase.Ended)
                {
                    Debug.Log("Temas kesildi");
                }
                if (touch.phase == TouchPhase.Moved)
                {
                    Debug.Log("Parmak hareket halinde");
                }
                if (touch.phase == TouchPhase.Stationary)
                {
                    Debug.Log("Parmak dokunmaya devam ediyor ama hareket etmiyor");
                }
            }
        }

        private void GetAxis()
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
        }
    }
}
