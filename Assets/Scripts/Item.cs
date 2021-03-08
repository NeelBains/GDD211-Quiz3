using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string Name;
    public int Calories;
    public int Karmas;
    public bool Alive;
    public string Message;

    private void OnMouseDown()
    {
        UseItem();
    }

    public virtual void UseItem()

    {
        //two lines below find a script called TellPlayer and call functions in it
        FindObjectOfType<TextManager>().WriteMessage(Message);
        FindObjectOfType<TextManager>().UpdateStats(Calories, Karmas);

    }
}
