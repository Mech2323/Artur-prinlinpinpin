using UnityEngine;

public class lista3a4 : MonoBehaviour
{

    [SerializeField] private int numero1;
    [SerializeField] private int numero2;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if( numero1 == numero2)
        {

            print("Eles são iguais");

        }
        else
        {

            print("são diferentes");

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
