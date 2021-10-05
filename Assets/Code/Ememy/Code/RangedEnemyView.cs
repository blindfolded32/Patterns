using System;
using System.Collections;
using Code.Ememy.Interfaces;
using UnityEngine;
using UnityEngine.AI;

namespace Code.Ememy.Code
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(NavMeshAgent))]
    public class RangedEnemyView : EnemyClass,IRangedEnemyView
    {
        public Transform Transform { get; private set; }
        public Vector3 Destination { get; set; }
        public void ChildCourutine(IEnumerator enumerator) => StartCoroutine(enumerator);
        public NavMeshAgent navMeshAgent;
        private IEnemyAttack _attack;
        private void Awake()
        {
            Transform = transform;
            _attack = new RangedEnemyAttack();
        }

        private void Start()
        {
            navMeshAgent.destination = Destination;
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.F)) _attack.Attack(gameObject);
        }
    }
}