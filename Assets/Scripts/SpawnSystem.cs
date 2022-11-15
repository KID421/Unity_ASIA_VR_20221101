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
        [SerializeField, Header("生成間隔"), Range(0, 5)]
        private float intervalSpawn = 2;

        // 事件：喚醒事件，播放遊戲後執行一次，大部分處理初始資料
        private void Awake()
        {
            // print("哈囉～");
            // SpawnObject();
            // 重複呼叫("方法名稱"，開始時間，間隔)
            // 0 秒後開始每隔兩秒呼叫 SpawnObject 方法
            InvokeRepeating("SpawnObject", 0, intervalSpawn);
        }

        private void SpawnObject()
        {
            // 暫存物件 = 生成物件(要生成的物件，座標，角度)
            // 生成 預製物雞 在 生成點的座標上 角度與生成點相同
            GameObject temp = Instantiate(prefabChicken, pointSpawn.position, pointSpawn.rotation);

            // 暫存物件.取得元件<剛體>().添加推力(發射力道)；
            temp.GetComponent<Rigidbody>().AddForce(shootPower);
        }
    }
}
