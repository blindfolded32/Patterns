using Code.Ememy.Interfaces;

namespace Code.Ememy.Code
{
    public struct EnemyModel : IEnemyModel
    {
        public float Speed { get; private set; }

        public EnemyModel(float speed) : this() => Speed = speed;
    }
}