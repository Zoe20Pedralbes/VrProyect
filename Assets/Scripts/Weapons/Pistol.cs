using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public override void Reload()
    {
        throw new System.NotImplementedException();
    }

    public override void Shot()
    {
        if (!reloading)
        {
            //Shot
            ActualAmmo--;
            if (ActualAmmo <= 0)
            {
                reloading = false;
                Invoke("reload",2);
            }
        }
    }

    protected override void reload()
    {
        reloading = true;
    }

}
