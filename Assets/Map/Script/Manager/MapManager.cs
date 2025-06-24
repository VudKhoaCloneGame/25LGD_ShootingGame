namespace GameSystem.Manager.Map
{
    using UnityEngine;

    public class MapManager : MonoBehaviour
    {
        [Header(" Prefab ")]
        public GameObject mapPrefab;

        private void Start()
        {
            GameObject mapGO = Instantiate(mapPrefab);           
        }
    }
}

