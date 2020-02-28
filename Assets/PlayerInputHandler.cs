﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField] private int damageAmount;
    [SerializeField] private PlayerHealt callDamageFunction;
    void OnMouseOver()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            callDamageFunction.TakeDamage(damageAmount);
        }
    }

}
