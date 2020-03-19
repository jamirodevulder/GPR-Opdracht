using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealt : MonoBehaviour
{
    [SerializeField] private int healt;
    [SerializeField] private ChangeText changeText;
    public UnityAction damage;
    public UnityAction dead;
    void Start()
    {
          
    }

    public void TakeDamage(int Damage)
    {
        damage();
        healt -= Damage;
        changeText.ChangeThisText(healt);
        if(healt <= 0)
        {
            dead();
            Destroy(gameObject);
        }

    }
}
