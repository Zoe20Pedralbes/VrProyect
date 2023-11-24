using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pistol : Weapon
{
    public InputActionAsset shootingAction;

    private void Start()
    {
        shootingAction.FindActionMap("Mouse").FindAction("Shot").performed += Shot;
        ActualAmmo = MaxAmmo;
    }
    public override void Reload()
    {
        throw new System.NotImplementedException();
    }

    public override void Shot(InputAction.CallbackContext ctx)
    {
        Shoot();
    }

    public void Shoot()
    {
        if (!reloading)
        {
            Debug.Log("Shot");
            //Shot
            ActualAmmo--;
            GameObject go = Instantiate(Bullet, spawnBullet);
            go.GetComponent<Bullet>().SetDirection(transform.forward, spawnBullet);
            if (ActualAmmo <= 0)
            {
                reloading = true;

                Invoke("reload", 2);
            }
        }
    }

    protected override void reload()
    {
        reloading = false;
        ActualAmmo = MaxAmmo;
    }

}
