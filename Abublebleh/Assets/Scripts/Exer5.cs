using UnityEngine;

public class Exer5 : MonoBehaviour
{

    [SerializeField] private int moedas = 17;
    [SerializeField] private int jogadores = 4;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log("Resto: " + (moedas % jogadores));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
