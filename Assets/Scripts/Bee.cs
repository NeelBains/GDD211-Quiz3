using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : Item
{
    public override void UseItem()
    {
        base.UseItem();
        Debug.Log("theres a Bee?");

    }
}
