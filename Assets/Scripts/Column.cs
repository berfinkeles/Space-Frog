using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Frog>() != null)
        {
            //If the frog hits the trigger collider in between the columns 
            GameController.instance.FrogScored();
        }
    }
}
