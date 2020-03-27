using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class gethit : MonoBehaviour
{
    [SerializeField] private Image image;
    private float trans;
    private bool hit = true;
    private bool undoBlack = false;
    private UnityAction gothitnow;

    // Start is called before the first frame update
    void Start()
    {
        hit = true;
        gameObject.GetComponent<PlayerHealt>().damage += gothit;

    }
    void Awake()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (hit)
        {
            Color c = image.color;
            c.a = trans;
            c.a += 0.06f;
            trans += 0.06f;
            image.color = c;
            if (image.color.a >= 1)
            {


                hit = false;
                undoBlack = true;


            }
        }
        if (undoBlack)
        {
            Color c = image.color;
            c.a = trans;
            c.a -= 0.06f;
            trans -= 0.06f;
            image.color = c;
            if (image.color.a <= 0)
            {

                undoBlack = false;


            }
        }
    }

    public void gothit()
    {
        trans = 0;
        hit = true;
        
    }
}


  

