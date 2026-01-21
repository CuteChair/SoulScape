using Unity.Cinemachine;
using UnityEngine;

public class SoulManager : MonoBehaviour
{
    [SerializeField] private GameObject greenSoulPrefab;
    [SerializeField] private GameObject blueSoulPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Transform blueSpawnPoint;
    [SerializeField] private Transform camTransform;
    [SerializeField] private float shootForce = 20f;
    

    private GameObject currentGreenSoul;
    private GameObject currentBlueSoul;

    public GameObject InstantiateGreenSoul()
    {
        currentGreenSoul = Instantiate(greenSoulPrefab, spawnPoint.position, Quaternion.identity);
        return currentGreenSoul;
    }

    public void DestroyGreenSoul()
    {
        if (currentGreenSoul != null)
        {
            Destroy(currentGreenSoul);
        }
    }
    
   public GameObject ShootBlueSoul()
    {
        if (blueSoulPrefab != null && camTransform != null)
        {
            currentBlueSoul = Instantiate(blueSoulPrefab, blueSpawnPoint.position, blueSpawnPoint.rotation);
            Rigidbody rb = currentBlueSoul.GetComponent<Rigidbody>();

            Vector3 shoot = camTransform.forward;

            if(rb != null)
            {
                rb.AddForce(shoot * shootForce, ForceMode.Impulse);
            }

            return currentBlueSoul;
        }

        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    GameObject BlueSoulInstance = Instantiate(BlueSoul, BlueSpawn.position, BlueSpawn.rotation);

        //    Rigidbody BlueSoulRB = BlueSoulInstance.GetComponent<Rigidbody>();

        //    Vector3 shootDirection = CinemachineCamera.forward;

        //    BlueSoulRB.AddForce(shootDirection * Speed, ForceMode.Impulse);

        //    Movements.IsInBlueSoulMode = true;


            Debug.LogWarning("Blue soul prefab or camera transform is not assigned");
        return null;
    }

    public void DestroyBlueSoul()
    {
        if (currentBlueSoul != null)
        {
            Destroy(currentBlueSoul);
        }
    }
}
