using UnityEngine;

public class Exer12 : MonoBehaviour
{

    [SerializeField] public int pontosBase;
    [SerializeField] public int kills;
    [SerializeField] public int bonus;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log("pontos: " + ((pontosBase * kills) + bonus));

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
