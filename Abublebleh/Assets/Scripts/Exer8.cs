using UnityEngine;

public class Exer8 : MonoBehaviour
{

    [SerializeField] public int vida = 100;
    [SerializeField] public int dano;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log("vida: " + (vida - dano));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
