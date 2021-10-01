using System;
using System.Collections;
using Code.Player.Interface;
using UnityEngine;

namespace Code.Player.Code
{
    public class PlayerView : UnitClass,IPlayerView
    {
        public Transform Transform { get;  set; }
        public Vector3 MoveDirection { get; set; }
        public CharacterController MovementControl { get; set; }

        private void Awake()
        {
            Transform = transform;
            MovementControl = GetComponent<CharacterController>();
        }
        public void ChildCourutine(IEnumerator enumerator) => StartCoroutine(enumerator);
    }
}