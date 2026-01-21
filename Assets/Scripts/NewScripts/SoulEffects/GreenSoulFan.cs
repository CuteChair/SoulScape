using Unity.VisualScripting;
using UnityEngine;

public class GreenSoulFan : MonoBehaviour
{
    [SerializeField] private Material[] materials;
    [SerializeField] private MeshRenderer[] meshRenderers;
    [SerializeField] private SkinnedMeshRenderer meshRendererSkinned;
    [SerializeField] private MeshCollider[] meshColliders;

    private void Start()
    {
        
    }
    public void SetWallsToGreenSoulMode()
    {
        Debug.Log("Player is in green soul mode : Can pass through walls");
        meshRenderers[0].material = materials[2];
        meshRenderers[1].material = materials[2];
        meshRendererSkinned.material = materials[2];
        foreach (MeshCollider collider in meshColliders)
        {
            if (collider != null)
            {
                collider.enabled = false;
            }
        }


       
    }

    public void ResetWalls()
    {
        Debug.Log("Walls reset to normal");
        meshRenderers[0].material = materials[0];
        meshRenderers[1].material = materials[0];
        meshRendererSkinned.material = materials[1];
        foreach (MeshCollider collider in meshColliders) { if (collider != null) {  collider.enabled = true; } }

    }
}
