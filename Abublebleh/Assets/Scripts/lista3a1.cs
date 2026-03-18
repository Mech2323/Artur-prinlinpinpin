using System.Runtime.CompilerServices;
using UnityEngine;

public class lista3a1 : MonoBehaviour
{

    [SerializeField] private int num1;
    [SerializeField] private int num2;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (num1 > num2)
        {

            print("o maior é: " + num1);


        }
        else
        {

            print("o maior é: " + num2);

        }

        // Update is called once per frame
        void Update()
        {

        }

    }
}
