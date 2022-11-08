using UnityEngine;

namespace KID
{
    /// <summary>
    /// 生成靶系統
    /// </summary>
    public class SpawnSystem : MonoBehaviour
    {
        [SerializeField, Header("要發射的雞")]
        private GameObject prefabChicken;
        [SerializeField, Header("生成點")]
        private Transform pointSpawn;
        [SerializeField, Header("發射力道")]
        private Vector3 shootPower = new Vector3(500, 1200, 0);
    }
}
