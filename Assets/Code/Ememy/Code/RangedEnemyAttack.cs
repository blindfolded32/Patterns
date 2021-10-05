using Code.Ememy.Interfaces;
using Code.Markers;
using UnityEngine;

namespace Code.Ememy.Code
{
    public class RangedEnemyAttack : IEnemyAttack
    {
        private readonly float _bulletspeed = 10.0f;
        public void Attack(GameObject spawner)
        {
            var bullet = Object.Instantiate(Resources.Load<Bullet>($"Prefab/BulletPrefab"), 
                                                spawner.transform.position, 
                                                Quaternion.identity);
            Physics.IgnoreCollision(bullet.GetComponent<Collider>(),
                                    spawner.GetComponent<Collider>());
            bullet.GetComponent<Rigidbody>().AddForce(spawner.transform.forward * _bulletspeed,
                                                        ForceMode.Impulse);
        }
    }
}