using UnityEngine;

public class Exer3 : MonoBehaviour
{

    [SerializeField] private int pontos = 10;
    [SerializeField] private int mltiplicador = 3;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log("pontuação: " + (pontos * mltiplicador));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
