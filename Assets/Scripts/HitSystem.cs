using UnityEngine;

namespace KID
{
    /// <summary>
    /// �I���t�ΡG�v�����O�_�Q�I��
    /// </summary>
    public class HitSystem : MonoBehaviour
    {
        private string nameBullet = "�l�u";
        private ScoreUpdate scoreUpdate;

        private void Awake()
        {
            scoreUpdate = FindObjectOfType<ScoreUpdate>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            // �p�G �I�� ���� ���W�� �]�t (�l�u)
            if (collision.gameObject.name.Contains(nameBullet))
            {
                scoreUpdate.AddScore();             // �[����
                Destroy(gameObject);                // �R��������
                Destroy(collision.gameObject);      // �R���I�쪺�l�u����
            }
        }
    }
}
