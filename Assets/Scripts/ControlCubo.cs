using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlCubo : MonoBehaviour
{
  
    public bool show = false;

    public bool tohide = false;

    void Awake()
    {

    }
    void Start()
    {
        
    }

    private void Update() 
    {
        /*if (Input.GetKeyDown(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(Vector3.Lerp(transform.rotation.eulerAngles, Vector3.up * 180, 2 * Time.deltaTime));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(Vector3.Lerp(transform.rotation.eulerAngles, Vector3.zero, 3 * Time.deltaTime));
        }*/
    }

    private void OnMouseDown() 
    {
        
        if (General.contClicks<2)
        {
            General.contClicks++;
            if (General.contClicks==1)
            {
                General.selecA=gameObject;
            }
            else if (General.contClicks==2)
            {
                General.selecB=gameObject;
            }
            
            
        }
        
        

    }

    /*public void Verification()
    {
        if (General.cubesVerificator[0].GetComponent<CardsControler>().mID == General.cubesVerificator[1].GetComponent<CardsControler>().mID)
        {
          
            Invoke("CubeDestroy", 1.7f);
        }
        else
        {
     
            Invoke("NoConcidence", 1.7f);
        }
    }

    public void CubeDestroy()
    {
        Destroy(General.cubesVerificator[0].gameObject);
        Destroy(General.cubesVerificator[1].gameObject);
      
        ++General.winConditional;
    }

    public void NoConcidence()
    {
        General.cubesVerificator[0].gameObject.GetComponent<CardsControler>().show = false;
        General.cubesVerificator[1].gameObject.GetComponent<CardsControler>().show = false;
        General.cubesVerificator[0] = null;
        General.cubesVerificator[1] = null;
        
    }*/

    /*private void Update() 
    {
        if (General.time <= 0)
        {
            
            if (General.cubesVerificator[0] != null)
                General.cubesVerificator[0].gameObject.GetComponent<CardsControler>().show = false;
            if (General.cubesVerificator[1] != null)
                General.cubesVerificator[1].gameObject.GetComponent<CardsControler>().show = false;
            
        }

        if (show == true)
            transform.rotation = Quaternion.Euler(Vector3.Lerp(transform.rotation.eulerAngles, Vector3.up * 180, 2 * Time.deltaTime));
        else
            transform.rotation = Quaternion.Euler(Vector3.Lerp(transform.rotation.eulerAngles, Vector3.zero, 2 * Time.deltaTime));
    }*/
}

