using Code.Ememy.Interfaces;
using Code.Ememy.Code;
using Code.Markers;
using UnityEngine;

namespace Code.Ememy
{
    public class EnemyFactory : IEnemyFactory
    {
        private IRangedController _rangedController;
        public EnemyClass Create(Health HP, EnemySpawn spawnPoint)
        {
            var rangedEnemy = Object.Instantiate(Resources.Load<RangedEnemyView>("Prefab/EnemyRange"));
            rangedEnemy.transform.position = spawnPoint.transform.position;
            rangedEnemy.DependencyHp(HP);
            Debug.Log($"spawned{rangedEnemy} at {spawnPoint}");
            _rangedController = new RangedController(new EnemyModel(2.0f), rangedEnemy);
            return rangedEnemy;
        }
    }
}