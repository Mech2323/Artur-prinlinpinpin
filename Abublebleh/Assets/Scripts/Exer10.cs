using UnityEngine;

public class Exer10 : MonoBehaviour
{

    [SerializeField] private float salario = 1000f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        float salarioTotal = salario - salario * 0.10f;

        Debug.Log("salario: " + salarioTotal);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
