using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealt : MonoBehaviour
{
    [SerializeField] private int healt;
    [SerializeField] private ChangeText changeText;


    public void TakeDamage(int Damage)
    {
        healt -= Damage;
        changeText.ChangeThisText(healt);
        if(healt <= 0)
        {
            Destroy(gameObject);
        }

    }
}
