using System;
using UnityEngine;

namespace GameObjectExamples
{
    public class GameObjectExample : MonoBehaviour
    {
        private BoxCollider _boxCollider;
        
        public Rigidbody _rigidbody;
        public Rigidbody[] rigidbodies;

        private SphereCollider _sphereCollider;

        private GameObjectExample2 _gameObjectExample2;

        public GameObject player3GameObject;

        private Player3 _player3;
        private void Start()
        {
            #region GameOBject

            // Debug.Log("Name : " + gameObject.name);
            // Debug.Log("Layer : " + gameObject.layer);
            // Debug.Log("Static : " + gameObject.isStatic);
            // Debug.Log("Tag : " + gameObject.tag);

            #endregion

            #region Transform

            // gameObject.transform.position -> uzun yazım
            
            // Debug.Log("Position : " + transform.position);
            // Debug.Log("PositionX : " + transform.position.x);
            // Debug.Log("PositionY : " + transform.position.y);
            // Debug.Log("PositionZ : " + transform.position.z);
            //
            // Debug.Log("Rotation : " + transform.localEulerAngles);
            // Debug.Log("RotationX : " + transform.localEulerAngles.x);
            // Debug.Log("RotationY : " + transform.localEulerAngles.y);
            // Debug.Log("RotationZ : " + transform.localEulerAngles.z);
            //
            // Debug.Log("Scale : " + transform.localScale);
            // Debug.Log("ScaleX : " + transform.localScale.x);
            // Debug.Log("ScaleY : " + transform.localScale.y);
            // Debug.Log("ScaleZ : " + transform.localScale.z);

            #endregion

            #region GetComponent
            
            //Debug.Log(gameObject.GetComponent<BoxCollider>().isTrigger); -> Uzun yazım

            // _boxCollider = GetComponent<BoxCollider>();
            //
            // if (_boxCollider != null)
            // {
            //     Debug.Log(_boxCollider.isTrigger);
            //     _boxCollider.isTrigger = false;
            // }
            //
            // _rigidbody = GetComponent<Rigidbody>();
            // _rigidbody.mass = 100;
            // _rigidbody.drag = 20;

            #endregion

            #region GetComponentChildren

            // _rigidbody = GetComponentInChildren<Rigidbody>();
            //
            // _rigidbody.mass = 100;
            //
            //
            // rigidbodies = GetComponentsInChildren<Rigidbody>();
            //
            // foreach (var rigidbody1 in rigidbodies)
            // {
            //     rigidbody1.mass = 20;
            // }

            #endregion

            #region GetComponent Parent

            // _sphereCollider = GetComponentInParent<SphereCollider>();
            // _sphereCollider.isTrigger = true;
            // _sphereCollider.radius = 5;
            //
            // _gameObjectExample2 = GetComponentInParent<GameObjectExample2>();
            //
            // _gameObjectExample2.name = "Player5";
            // _gameObjectExample2.power = 100;
            //
            // Debug.Log(_gameObjectExample2.name);
            // Debug.Log(_gameObjectExample2.power);
            

            #endregion

            #region Gameobject Find

            //player3GameObject = GameObject.Find("Player3");
            
            //player3GameObject = GameObject.FindGameObjectWithTag("Player");
            
            // Debug.Log(player3GameObject.name);
            // Debug.Log(player3GameObject.tag);
            // Debug.Log(player3GameObject.layer);

            _player3 = player3GameObject.GetComponent<Player3>();
            Debug.Log(_player3.name);
            Debug.Log(_player3.health);
            
            _player3.TakeDamage();
            
            Debug.Log(_player3.health);
            
            #endregion

        }
    }
}
