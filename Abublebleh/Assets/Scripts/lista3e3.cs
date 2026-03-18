using UnityEngine;

public class lista3e3 : MonoBehaviour
{

    [SerializeField] private int numero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        if (numero % 2 == 0)
        {
            print("é par");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
