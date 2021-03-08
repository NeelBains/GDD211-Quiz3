using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : Item
{
    public override void UseItem()
    {
        base.UseItem();
        Debug.Log("this aint food");

    }
}
