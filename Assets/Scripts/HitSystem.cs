using UnityEngine;

namespace KID
{
    /// <summary>
    /// 碰撞系統：靶偵測是否被碰到
    /// </summary>
    public class HitSystem : MonoBehaviour
    {
        private string nameBullet = "子彈";
        private ScoreUpdate scoreUpdate;

        private void Awake()
        {
            scoreUpdate = FindObjectOfType<ScoreUpdate>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            // 如果 碰到 物件 的名稱 包含 (子彈)
            if (collision.gameObject.name.Contains(nameBullet))
            {
                scoreUpdate.AddScore();             // 加分數
                Destroy(gameObject);                // 刪除此物件
                Destroy(collision.gameObject);      // 刪除碰到的子彈物件
            }
        }
    }
}
