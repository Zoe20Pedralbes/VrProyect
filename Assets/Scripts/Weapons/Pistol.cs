using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pistol : Weapon
{
    private void Start()
    {
        shootingAction.FindActionMap("Mouse").FindAction("Shot").performed += Shot;
        ActualAmmo = MaxAmmo;
        lastShot = Time.time;
    }

    public override void Shot(InputAction.CallbackContext ctx)
    {
        Shoot();
    }

    //public void Shoot()
    //{
    //    if (!reloading && lastShot < Time.time)
    //    {
    //        lastShot = Time.time + FireRate;
    //        Debug.Log("Shot");
    //        Shot
    //        ActualAmmo--;
    //        GameObject go = Instantiate(Bullet, spawnBullet);
    //        go.GetComponent<Bullet>().SetDirection(transform.forward, spawnBullet);
    //        if (ActualAmmo <= 0)
    //        {
    //            reloading = true;

    //            Invoke("Reload", 2);
    //        }
    //    }
    //}

}
