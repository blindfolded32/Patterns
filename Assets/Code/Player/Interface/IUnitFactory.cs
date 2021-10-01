using UnityEngine;

namespace Code.Player.Interface
{
    public interface IUnitFactory
    {
        UnitClass Create(Health hp, Vector3 position);
    }
}