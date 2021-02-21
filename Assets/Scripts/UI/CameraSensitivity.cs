using Cinemachine;
using UnityEngine;

namespace Artistas
{

    public class CameraSensitivity : MonoBehaviour
    {
        [SerializeField] private CinemachineVirtualCamera cinemachineVirtualCamera;

        private CinemachinePOV cinemachinePOV;

        private void Awake()
        {
            cinemachinePOV = cinemachineVirtualCamera.GetCinemachineComponent<CinemachinePOV>();
        }

        public void UpdateSensitivity(float value)
        {
            cinemachinePOV.m_VerticalAxis.m_MaxSpeed = value;
            cinemachinePOV.m_HorizontalAxis.m_MaxSpeed = value;
        }
    }
}