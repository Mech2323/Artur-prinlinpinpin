using UnityEngine;

public class Exer2 : MonoBehaviour
{

    [SerializeField] private int vida;
    [SerializeField] private int dano;

    void Start()
    {
        int vida = 100;
        int dano = 25;

        Debug.Log("vida: " + (vida - dano));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
