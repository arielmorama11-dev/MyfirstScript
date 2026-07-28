using System.Globalization;
using UnityEngine;

public class FundamentosProgramacion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Tipos de Datos
    private int myNumber = 14; // int - numero entero
    public float myFloatNumber = 25.20f;//FLOAT - numero con punto decimal 
    public string myString = "Put your message here"; // string - cadena de texto 

    public int health; // variables globales 
    
    void Start()
    {
        int localHealth = 50;// variables locales 
        //Debug.Log("Hola, estoy en la funcion start");
        //Debug.LogWarning("My number is: " + myNumber);
        //Debug.Log("Message is: " + myString);
        //Debug.Log("My Float Number is: " + myFloatNumber);
        health = 100; // guardando un valor en una variable global

        int newHealth = health + localHealth; // sumando el valor de una variable global y local
        Debug.Log("Health: " + newHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hola, estoy en la funcion update");
    }
}
