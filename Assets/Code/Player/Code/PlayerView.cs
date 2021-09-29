using System;
using System.Collections;
using Code.Player.Interface;
using UnityEngine;

namespace Code.Player.Code
{
    public class PlayerView : MonoBehaviour,IPlayerView
    {
        public Transform Transform { get; private set; }
        public Vector3 MoveDirection { get; set; }
        public CharacterController MovementControl { get; set; }

        private void Awake()
        {
            Transform = transform;
            MovementControl = GetComponent<CharacterController>();
        }

        public void Movement()
        {
            throw new System.NotImplementedException();
        }

        public void ChildCourutine(IEnumerator enumerator) => StartCoroutine(enumerator);
    }
}