using Code.Player;
using Code.Markers;
using UnityEngine;

namespace Code
{
    public class GameStarter : MonoBehaviour
    {
        private IUnitFactory _unitFactory;
        // Start is called before the first frame update
        private void Start()
        {
            _unitFactory = new UnitFactory();
            UnitClass.Factory = _unitFactory;
            UnitClass.Factory.Create(new Health(100.0f, 100.0f),FindObjectOfType<PlayerSpawn>().transform.position);
        }

        // Update is called once per frame
        private void Update()
        {
            _unitFactory.OnUpdate();
        }
    }
}
