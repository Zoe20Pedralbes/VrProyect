using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected GameObject Bullet;
    [SerializeField] protected Transform spawnBullet;
    [SerializeField] protected float ReloadTime;
    protected bool reloading;
    protected int MaxAmmo;
    protected int ActualAmmo;


    public abstract void Shot();
    public abstract void Reload();

    protected abstract void reload();
}
