using UnityEngine;

public class Exer7 : MonoBehaviour
{

    [SerializeField] private int numero1;
    [SerializeField] private int numero2;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log("soma " + (numero1 + numero2));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
