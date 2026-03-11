using UnityEngine;

public class Exer9 : MonoBehaviour
{

    [SerializeField] private int numero;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log("Dobro: " + (numero * 2) + " metade: " + (numero / 2));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
