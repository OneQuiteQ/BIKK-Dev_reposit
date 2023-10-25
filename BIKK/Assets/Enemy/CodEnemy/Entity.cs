using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public virtual void GetDamage()
    {

    }

    public void Die()
    {
        Destroy(this.gameObject);
    }

}
