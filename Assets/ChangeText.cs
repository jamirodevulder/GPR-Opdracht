using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    private string textInfrontOfHealth = "health: ";
    public void ChangeThisText(int health)
    {
        
        gameObject.GetComponent<TextMesh>().text = textInfrontOfHealth + health;
    }
}
