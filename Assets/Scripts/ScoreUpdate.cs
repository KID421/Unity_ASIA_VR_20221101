using UnityEngine;
using UnityEngine.UI;

namespace KID
{
    /// <summary>
    /// 分數更新管理器
    /// </summary>
    public class ScoreUpdate : MonoBehaviour
    {
        [SerializeField, Header("分數文字")]
        private Text textScore;
        [SerializeField, Header("每次累加分數"), Range(0, 500)]
        private int scoreAdd = 100;

        private int scoreTotal;
    }
}
