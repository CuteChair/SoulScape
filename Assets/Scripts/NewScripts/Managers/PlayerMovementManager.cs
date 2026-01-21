using UnityEngine;

public class PlayerMovementManager : MonoBehaviour
{
    [SerializeField] private PlayerMovements movements;
    [SerializeField] private PossessedMovements possessedMovements;

    private void Start()
    {
        movements = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovements>();
    }

    public void SetMovementEnabled(bool enabled)
    {
        if (movements != null)
        {
            movements.enabled = enabled;
            Debug.Log($"PlayerMovements script {(enabled ? "enabled" : "disabled")}");
        }
        else
        {
            Debug.LogWarning("Missing movement script in PlayerMovementManager");
        }
    }

    public void SetPossessedMovements(bool enabled)
    {
        possessedMovements.enabled = enabled;
    }
}
