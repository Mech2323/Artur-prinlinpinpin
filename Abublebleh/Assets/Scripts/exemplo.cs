using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    [SerializeField]string nome;
    [SerializeField]float horasT;
    [SerializeField]float Vhora;
    [SerializeField]float Salario;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        float Salario = Vhora * horasT;

        print(nome + " trabalhou " +  horasT + " e ganhou " + Salario);

    }























    // Update is called once per frame
    void Update()
    {
        
    }
}
