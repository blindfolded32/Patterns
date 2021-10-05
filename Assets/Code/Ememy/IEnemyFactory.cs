using Code.Markers;
using UnityEngine;

namespace Code.Ememy
{
    public interface IEnemyFactory
    {
        EnemyClass Create(Health HP, EnemySpawn spawnPoint);
    }
}