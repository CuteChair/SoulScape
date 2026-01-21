using System.Xml;
using UnityEngine;

public class SwitchToLvlOne : MonoBehaviour
{
    [SerializeField] private SceneSwitcher switcher;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switcher.SwitchToScene("Level 1");
        }
    }
}
