using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

namespace KID
{
    /// <summary>
    /// 發射子彈系統
    /// </summary>
    public class FireSystem : MonoBehaviour
    {
        [SerializeField, Header("子彈預製物")]
        private GameObject prefabBullet;
        [SerializeField, Header("生成子彈位置")]
        private Transform pointSpawnBullet;
        [SerializeField, Header("子彈發射速度"), Range(500, 3000)]
        private int speedBullet = 1000;
        [SerializeField, Header("VR 控制器按鍵")]
        private SteamVR_Action_Boolean action;

        private Interactable interactable;

        private void Awake()
        {
            interactable = GetComponent<Interactable>();
        }

        private void Update()
        {
            Fire();
        }

        /// <summary>
        /// 發射子彈
        /// </summary>
        private void Fire()
        {
            // 如果 手上有東西
            if (interactable.attachedToHand != null)
            {
                // 如果 按下控制器按鍵
                SteamVR_Input_Sources input = interactable.attachedToHand.handType;

                if (action[input].stateDown)
                {
                    // 就生成子彈
                    GameObject temp = Instantiate(prefabBullet, pointSpawnBullet.position, pointSpawnBullet.rotation);
                    // 發射子彈
                    temp.GetComponent<Rigidbody>().AddForce(transform.right * speedBullet);
                }
            }

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GameObject temp = Instantiate(prefabBullet, pointSpawnBullet.position, pointSpawnBullet.rotation);
                temp.GetComponent<Rigidbody>().AddForce(transform.right * speedBullet);
            }
        }
    }
}
