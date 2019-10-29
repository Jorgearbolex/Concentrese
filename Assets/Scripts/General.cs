using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class General : MonoBehaviour
{
    public GameObject[] cubos = new GameObject[8];
    public Vector3[] positions; 
    public static GameObject selecA, selecB, selected;
    public static int contClicks=0;
    public static bool hide, enVerificacion;

     
    void Awake() 
    {
        int contador = 0;
        cubos=GameObject.FindGameObjectsWithTag("cubo");
        positions = new Vector3[cubos.Length];
        foreach (var item in cubos)
        {
            positions[contador] = item.transform.position;// aqui las posiciones actuan con base en el contador y como va aumentando para asignar cada posición de 0 a 15
            item.GetComponent<ControlCubo>().metaid = contador;
            contador++;
        }
        Revolcon();
    }

    void Start () 
    {

    }

    void Update()
    {
        VerificationCube();
        
    }
    
    void Revolcon()
    {

        for (int i = 0; i < cubos.Length; i++)
        {
            Vector3 aux;
            int azarpos=Random.Range(0,positions.Length); // se utiliza para repartir klas posiciones ramdom
            aux = positions[i]; //esta variable auxiliar guarda la posicion de interaccion (i)
            positions[i] = positions[azarpos]; //esta variable guarda la posicion aleatoria en la posicion de interaccion (i)
            positions[azarpos] = aux; ////esta variable auxiliar representa la posicion aleatoria
        }
        for (int i = 0; i < cubos.Length; i++)
        {
            cubos[i].transform.position = positions[i]; // posicion aleatoria se le asigna al cubo en interacción (i)
        }
    }

    

    void VerificationCube()
    {
        if (contClicks == 1)
        {
            selecA = selected;

        }
        else if(contClicks == 2)
        {
            selecB = selected;
            enVerificacion = true;
            Invoke("Verificacion",1.5f);
            contClicks = 0;
        }

    }

    void Verificacion()
    {
        bool comparacion = selecA.GetComponent<ControlCubo>().identificadorCubo == selecB.GetComponent<ControlCubo>().identificadorCubo
            && selecA.GetComponent<ControlCubo>().metaid != selecB.GetComponent<ControlCubo>().metaid;
        if (comparacion)
        {
            selecA.transform.position += transform.forward * 10;
            selecB.transform.position += transform.forward * 10;
        }
        else
        {
            selecA.GetComponent<ControlCubo>().selected = false;
            selecB.GetComponent<ControlCubo>().selected = false;
        }

        enVerificacion = false;

    }
}

