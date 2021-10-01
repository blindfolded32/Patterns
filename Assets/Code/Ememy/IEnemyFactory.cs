using UnityEngine;

namespace Code.Ememy
{
    public interface IEnemyFactory
    {
        EnemyClass Create(Health HP, Vector3 spawnPoint);
    }
}