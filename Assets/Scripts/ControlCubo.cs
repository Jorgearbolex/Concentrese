using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlCubo : MonoBehaviour
{
    public bool selected;
    public int identificadorCubo, metaid;

    void Awake()
    {

    }
    void Start()
    {
        
    }

    private void Update() 
    {
        
        if (selected)
        {
            transform.rotation = Quaternion.Euler(Vector3.Lerp(transform.rotation.eulerAngles, Vector3.up * 180, 3 * Time.deltaTime));
        }
        else
        {
            transform.rotation = Quaternion.Euler(Vector3.Lerp(transform.rotation.eulerAngles, Vector3.zero, 3 * Time.deltaTime));
        }
    }

    private void OnMouseDown() 
    {
        
        Verification();
        
    }

    void Verification()
    {
        if (General.enVerificacion==false)
        {
            if (General.selected != gameObject)
            {
                General.selected = gameObject;
            }

            General.contClicks++;
            selected = true;
        }
        
    }

    
}

