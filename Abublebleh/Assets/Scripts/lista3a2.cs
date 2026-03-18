using UnityEngine;

public class lista3a2 : MonoBehaviour
{


    [SerializeField] private int idade;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (idade >= 18)
        {

            print("você é maior de idade.");
        }
        else {

            print("ta não.");

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
