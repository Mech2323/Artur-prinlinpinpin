using UnityEngine;

public class Exer4 : MonoBehaviour
{

    [SerializeField] private int moedas = 100;
    [SerializeField] private int jogadores = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log("divisão: " + (moedas / jogadores));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
