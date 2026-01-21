using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    public PlayerState CurrentState { get; private set; } = PlayerState.PLAYER;

    public void SwitchState(PlayerState newState)
    {
        CurrentState = newState;
        Debug.Log($"Player state : {newState}");
    }
}
