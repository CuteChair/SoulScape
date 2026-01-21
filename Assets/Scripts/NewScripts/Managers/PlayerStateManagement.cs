using UnityEngine;

public class PlayerStateManagement : MonoBehaviour
{
    [SerializeField] private PlayerStateManager stateManager;
    [SerializeField] private PlayerMovementManager movementManager;
    [SerializeField] private PlayerCameraManager cameraManager;
    
    [SerializeField] private SoulManager soulManager;
    [SerializeField] private PowerManager powerManager;
    [SerializeField] private GreenSoulFan greenSoulWalls;
    [SerializeField] private PossessedCollision possessedCollision;


    private void Start()
    {
        if (stateManager == null || movementManager == null || cameraManager == null || soulManager == null || powerManager == null)
        {
            Debug.LogError("PlayerStateManagement is missing dependencies");
        }
    }

    private void Update()
    {
        HandleBlueState();
        HandleGreenSoulState();
        HandlePossessed();
    }

    private void HandleGreenSoulState()
    {
        if (Input.GetKeyDown(KeyCode.E) && stateManager.CurrentState != PlayerState.BLUESOUL && powerManager.isGreenSoulUnlocked == true && stateManager.CurrentState != PlayerState.POSSESSED)
        {
            if(stateManager.CurrentState == PlayerState.PLAYER)
            {
                stateManager.SwitchState(PlayerState.GREENSOUL);
                movementManager.SetMovementEnabled(false);
                cameraManager.SetCameraActive(false);
                soulManager.InstantiateGreenSoul();
                if(greenSoulWalls != null)
                {
                    greenSoulWalls.SetWallsToGreenSoulMode();
                }
                
            }
            else
            {
                stateManager.SwitchState(PlayerState.PLAYER);
                movementManager.SetMovementEnabled(true);
                cameraManager.SetCameraActive(true);
                soulManager.DestroyGreenSoul(); 
                if(greenSoulWalls != null)
                {
                    greenSoulWalls.ResetWalls();
                }
                
            }
        }
    }

    private void HandleBlueState()
    {
        if (Input.GetKeyDown(KeyCode.Q) && stateManager.CurrentState != PlayerState.GREENSOUL && powerManager.isBlueSoulUnlocked == true && stateManager.CurrentState != PlayerState.POSSESSED)
        {
            if (stateManager.CurrentState == PlayerState.PLAYER)
            {
                stateManager.SwitchState(PlayerState.BLUESOUL);
                movementManager.SetMovementEnabled(false);
                cameraManager.SetCameraActive(false);
                soulManager.ShootBlueSoul();
            }
            else
            {
                stateManager.SwitchState(PlayerState.PLAYER);
                movementManager.SetMovementEnabled(true);
                cameraManager.SetCameraActive(true);
                soulManager.DestroyBlueSoul();
            }
        }
    }

    private void HandlePossessed()
    {
        if(possessedCollision != null)
        {
            if (possessedCollision.isPossessed == true)
            {
                stateManager.SwitchState(PlayerState.POSSESSED);
                cameraManager.SetCameraActive(false);
                cameraManager.SetPossessedCamActive(true);
                movementManager.SetMovementEnabled(false);
                movementManager.SetPossessedMovements(true);
                Debug.Log("Player has possessed an item");
                possessedCollision.isPossessed = false;
            }
            else if (Input.GetKeyDown(KeyCode.Q) && stateManager.CurrentState == PlayerState.POSSESSED)
            {
                stateManager.SwitchState(PlayerState.PLAYER);
                cameraManager.SetCameraActive(true);
                cameraManager.SetPossessedCamActive(false);
                movementManager.SetMovementEnabled(true);
                movementManager.SetPossessedMovements(false);
            }

        }

    }
}
