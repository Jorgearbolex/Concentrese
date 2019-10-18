using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class General : MonoBehaviour
{
    public GameObject[] materialetes = new GameObject[8];
    public static GameObject selecA, selecB;
    public static int contClicks=0;
    public static bool hide;
    void Awake() 
    {
        materialetes=GameObject.FindGameObjectsWithTag("cubo");
        foreach (var item in materialetes)
        {
            //item.Getcomponent
        }
     
    }

    void Start () 
    {
       
        






    }

    void Update()
    {
        /*if (selecA!=null||selecB!=null)
        {
            selecA.transform.rotation = Quaternion.Euler(Vector3.Lerp(selecA.transform.rotation.eulerAngles, Vector3.up * 180, 2 * Time.deltaTime));
            selecB.transform.rotation = Quaternion.Euler(Vector3.Lerp(selecB.transform.rotation.eulerAngles, Vector3.up * 180, 2 * Time.deltaTime));
        }*/


        if (contClicks==1)
        {
            selecA.transform.rotation = Quaternion.Euler(Vector3.Lerp(selecA.transform.rotation.eulerAngles, Vector3.up * 180, 2 * Time.deltaTime));
        }
        else if (contClicks==2)
        {
            selecB.transform.rotation = Quaternion.Euler(Vector3.Lerp(selecB.transform.rotation.eulerAngles, Vector3.up * 180, 2 * Time.deltaTime));
            Invoke("ActiveHide", 3);
            Debug.Log("que rico dos pares de conyonsions");
        }

        if (hide)
        {
            selecA.transform.rotation = Quaternion.Euler(Vector3.Lerp(selecA.transform.rotation.eulerAngles, Vector3.zero, 3 * Time.deltaTime));
            selecB.transform.rotation = Quaternion.Euler(Vector3.Lerp(selecB.transform.rotation.eulerAngles, Vector3.zero, 3 * Time.deltaTime));
            if (contClicks==0)
            {
                hide=false;
            }
        }
    
    }

    void ActiveHide()
    {
        hide=true;
        contClicks=0;
    }

    /*void Hide()
    {
        selecA.transform.rotation = Quaternion.Euler(Vector3.Lerp(selecA.transform.rotation.eulerAngles, Vector3.zero, 3 * Time.deltaTime));
        selecB.transform.rotation = Quaternion.Euler(Vector3.Lerp(selecB.transform.rotation.eulerAngles, Vector3.zero, 3 * Time.deltaTime));
        hide=false;
    }*/
}

