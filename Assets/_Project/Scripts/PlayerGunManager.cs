using UnityEngine;
using Mirror;
using UnityEngine.InputSystem;

public class PlayerGunManager : NetworkBehaviour 
{
    private Weapon weapon;
    private GameObject projectilePrefab;
    private Transform shootingPoint;

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            weapon?.ShootInputDown();
        }
        else if (context.canceled)
        {
            weapon?.ShootInputUp();
        }
    }

    public void OnReload(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            weapon?.ReloadInputUpdate();
        }
    }

    void Start()
    {
        weapon = GetComponentInChildren<Weapon>();
        if (!isLocalPlayer)
        {
            weapon.enabled = false;
            enabled = false;
        }
        if(weapon.GetComponent<ProjectileWeapon>())
        {
            projectilePrefab = weapon.GetComponent<ProjectileWeapon>().projectilePrefab;
            shootingPoint = weapon.GetComponent<ProjectileWeapon>().ShootingPoint;
        }
    }

    [Command]
    public void CmdShootCommand()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, shootingPoint.transform.position, shootingPoint.transform.rotation);
        NetworkServer.Spawn(projectileObject);
    }
}
