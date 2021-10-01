using UnityEngine;

namespace Code.Player
{
    public interface IUnitFactory
    {
      UnitClass Create(Health hp, Vector3 spawnPoint);
      void OnUpdate();
    }
}