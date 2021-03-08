using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : Item
{
    public override void UseItem()
    {
        base.UseItem();
        Debug.Log("bruh this is a bear");

    }
}
