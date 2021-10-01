using Code.Player;
using UnityEngine;
using IUnitFactory = Code.Player.IUnitFactory;

namespace Code
{
    public class GameStarter : MonoBehaviour
    {
        private IUnitFactory _unitFactory;
        // Start is called before the first frame update
        void Start()
        {
            _unitFactory = new UnitFactory();
            //   unitFactory.Create(new Health(100.0f, 100.0f),FindObjectOfType<PlayerSpawn>().transform.position);
            UnitClass.Factory = _unitFactory;
            UnitClass.Factory.Create(new Health(100.0f, 100.0f),FindObjectOfType<PlayerSpawn>().transform.position);
        }

        // Update is called once per frame
        void Update()
        {
            _unitFactory.OnUpdate();
        }
    }
}
