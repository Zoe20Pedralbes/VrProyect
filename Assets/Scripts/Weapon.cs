using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected GameObject Bullet;
    [SerializeField] protected Transform spawnBullet;
    [SerializeField] protected float ReloadTime;
    [SerializeField] protected bool reloading;
    [SerializeField] protected int MaxAmmo;
    protected int ActualAmmo;


    public abstract void Shot(InputAction.CallbackContext ctx);
    protected abstract void Reload();
}
