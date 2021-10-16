using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyProgram : MonoBehaviour
{
    // Start is called before the first frame update


    private void Awake()
    {
        Vegetales vegetales = new Vegetales("Vegetales");
        vegetales.Use();

        int price = vegetales.GetPrice();
        Console.WriteLine(price);

        vegetales.SetPrice(8);
        price = vegetales.GetPrice();
        Console.WriteLine(price);


        Console.WriteLine(vegetales.quantity);
        vegetales.quantity = 16;
        Console.WriteLine(vegetales.quantity);


        Menestras menestras = new Menestras();
        Console.WriteLine(menestras.newUse());

        Frutas frutas = new Frutas();
    }


    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }







}
