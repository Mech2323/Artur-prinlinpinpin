using UnityEngine;

public class Exer11 : MonoBehaviour
{


    [SerializeField] private float velocidadeInicial;
    [SerializeField] private float aceleracao;
    [SerializeField] private float tempo;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log("velocidade: " + (velocidadeInicial + aceleracao * tempo));


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
