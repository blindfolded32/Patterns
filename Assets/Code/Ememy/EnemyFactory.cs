using Code.Ememy.Interfaces;
using Code.Ememy.Code;
using UnityEngine;

namespace Code.Ememy
{
    public class EnemyFactory : IEnemyFactory
    {
        private IRangedController _rangedController;
        public EnemyClass Create(Health HP, Vector3 spawnPoint)
        {
            var rangedEnemy = Resources.Load<RangedEnemyView>("Prefab/RagedEnemy");
            rangedEnemy.transform.position = spawnPoint;
            rangedEnemy.DependencyHp(HP);
            _rangedController = new RangedController(new EnemyModel(), rangedEnemy);
            return rangedEnemy;
        }
    }
}