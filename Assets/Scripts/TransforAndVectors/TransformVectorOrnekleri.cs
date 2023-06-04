using System;
using UnityEngine;

namespace TransforAndVectors
{
    public class TransformVectorOrnekleri : MonoBehaviour
    {
        public Vector3 rotation;
        public float speed;
        public float rotateSpeed;
        public float scaleSpeed;
        
        [SerializeField] private Transform cube2;
        [SerializeField] private GameObject cube2New;

        [SerializeField] private float lerpSpeed;
        // 30 * 1/30 = 60 * 1/60
        private void Start()
        {
            //TransformChange();
            
            VectorOperating();
        }

        private void Update()
        {
            //Move();
            
            //Rotate();

            //Scale();
            
            //Distance();
            
            //Lerp();
        }

        private void TransformChange()
        {
            // Vector3 newVector3 = new Vector3(2.2f, 3, 4);
            // //Vector3Int newVector3Int = new Vector3Int(1.2f, 0, 2);
            // Debug.Log(newVector3);
            // Debug.Log(newVector3.x);
            // Debug.Log(newVector3.y);
            // Debug.Log(newVector3.z);
            //
            // transform.position = newVector3;

            //transform.position.y = 2;

            //transform.position = new Vector3(2, 0, 5);
            //transform.position = new Vector3(2, transform.position.y, transform.position.z);
            //transform.position = new Vector3(transform.position.x, 5,  transform.position.z);
            //transform.position = new Vector3(transform.position.x, transform.position.y, 10);

            //transform.eulerAngles = new Vector3(90, 0, 0);
            //transform.eulerAngles = rotation;

            //transform.localScale = new Vector3(2, 5, 7);
        }

        private void VectorOzelTanimliDegerler()
        {
            Debug.Log(Vector3.zero);
            transform.position = Vector3.zero; // new Vector3(0, 0, 0);
            Debug.Log(Vector3.one);
            Debug.Log(Vector3.right);
            Debug.Log(Vector3.left);
            Debug.Log(Vector3.forward);
            Debug.Log(Vector3.back);
            Debug.Log(Vector3.up);
            Debug.Log(Vector3.down);
        }

        private void Move()
        {
            Debug.Log(Time.deltaTime);
            transform.position += new Vector3(0, 0, 1) * (speed * Time.deltaTime);
            transform.position += Vector3.forward * (speed * Time.deltaTime);
            transform.position += Vector3.back * (speed * Time.deltaTime);
            
            transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        }

        private void Rotate()
        {
            transform.Rotate(Vector3.right * (rotateSpeed * Time.deltaTime));
        }

        private void Scale()
        {
            transform.localScale += Vector3.one * (scaleSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.A))
            {
                transform.localScale += Vector3.one * (scaleSpeed * Time.deltaTime);
            }
            
            if (Input.GetKey(KeyCode.B))
            {
                transform.localScale -= Vector3.one * (scaleSpeed * Time.deltaTime);
            }
        }

        private void Distance()
        {
            if (!cube2.gameObject.activeInHierarchy)
            {
                return;
            }
            float mesafe = Vector3.Distance(transform.position, cube2.position);
            //float mesafe2 = Vector3.Distance(transform.position, cube2New.transform.position);
            
            Debug.Log("Mesafemiz : " + mesafe);

            if (mesafe < 2)
            {
                cube2.gameObject.SetActive(false);
                //cube2New.SetActive(false);
            }
        }

        private void Lerp()
        {
            transform.position = Vector3.Lerp(transform.position, cube2.position, lerpSpeed * Time.deltaTime);
        }

        private void VectorOperating()
        {
            Vector3 firstVector = new Vector3(2, 5, 10);
            Vector3 secondVector = Vector3.one;

            Vector3 toplam = firstVector + secondVector;
            Vector3 fark = firstVector - secondVector;

            Debug.Log("Vector toplamı : " + toplam);
            Debug.Log("Vector farkı : " + fark);
            
            Debug.Log(firstVector * 2);
            Debug.Log(secondVector / 2);
            Debug.Log(secondVector * 0.5f);
        }
    }
}
