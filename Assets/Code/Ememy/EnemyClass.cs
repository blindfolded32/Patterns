using Code.Ememy.Code;
using UnityEngine;

namespace Code.Ememy
{
    public class EnemyClass : MonoBehaviour
    {
        public static IEnemyFactory Factory;
        private Health Health;

        public static RangedEnemyView CreateRangedEnemy(Health hp, Vector3 spawnPosition)
        {
            var rangedEnemy = Resources.Load<RangedEnemyView>("Prefab/RagedEnemy");
            rangedEnemy.Health = hp;
            return rangedEnemy;
        }
        public void DependencyHp(Health hp) => Health = hp;
    }
}