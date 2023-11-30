using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class Weapon : MonoBehaviour
{
    public InputActionAsset shootingAction;
    [SerializeField] protected GameObject Bullet;
    [SerializeField] protected Transform spawnBullet;
    [SerializeField] protected float ReloadTime;
    [SerializeField] protected float FireRate;
    protected float lastShot;
    [SerializeField] protected bool reloading;
    [SerializeField] protected int MaxAmmo;
    protected int ActualAmmo;


    public abstract void Shot(InputAction.CallbackContext ctx);
    protected virtual void Reload()
    {
        reloading = false;
        ActualAmmo = MaxAmmo;
    }
    public virtual void Shoot()
    {
        if (!reloading && lastShot < Time.time)
        {
            lastShot = Time.time + FireRate;
            Debug.Log("Shot");
            //Shot
            ActualAmmo--;
            GameObject go = Instantiate(Bullet, spawnBullet);
            go.GetComponent<Bullet>().SetDirection(transform.forward, spawnBullet);
            if (ActualAmmo <= 0)
            {
                reloading = true;

                Invoke("Reload", 2);
            }
        }
    }
}
