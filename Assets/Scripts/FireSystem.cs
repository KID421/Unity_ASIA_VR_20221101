using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

namespace KID
{
    /// <summary>
    /// �o�g�l�u�t��
    /// </summary>
    public class FireSystem : MonoBehaviour
    {
        [SerializeField, Header("�l�u�w�s��")]
        private GameObject prefabBullet;
        [SerializeField, Header("�ͦ��l�u��m")]
        private Transform pointSpawnBullet;
        [SerializeField, Header("�l�u�o�g�t��"), Range(500, 3000)]
        private int speedBullet = 1000;
        [SerializeField, Header("VR �������")]
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
        /// �o�g�l�u
        /// </summary>
        private void Fire()
        {
            // �p�G ��W���F��
            if (interactable.attachedToHand != null)
            {
                // �p�G ���U�������
                SteamVR_Input_Sources input = interactable.attachedToHand.handType;

                if (action[input].stateDown)
                {
                    // �N�ͦ��l�u
                    GameObject temp = Instantiate(prefabBullet, pointSpawnBullet.position, pointSpawnBullet.rotation);
                    // �o�g�l�u
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
