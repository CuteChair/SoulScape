using UnityEngine;

public class LoadSecLevel : MonoBehaviour
{
    [SerializeField] private SceneSwitcher switcher;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switcher.SwitchToScene("Level 2");
        }
    }
}
