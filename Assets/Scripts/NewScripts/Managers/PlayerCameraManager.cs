using Unity.Cinemachine;
using UnityEngine;

public class PlayerCameraManager : MonoBehaviour
{
    [SerializeField] private CinemachineCamera playerCam;
    [SerializeField] private CinemachineCamera possessedCam;

    public void SetCameraActive(bool active)
    {
        if (playerCam != null)
        {
            playerCam.gameObject.SetActive(active);
            Debug.Log($"Camera {(active ? "activated" : "deactivated")}");
        }     
        
    }

    public void SetPossessedCamActive(bool active)
    {
        if (possessedCam != null)
        {
            possessedCam.gameObject.SetActive(active);
        }
    }
}
