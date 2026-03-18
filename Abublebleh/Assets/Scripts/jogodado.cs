using UnityEngine;

public class jogodado : MonoBehaviour
{

    [SerializeField] private int pontos1;
    [SerializeField] private int pontos2;
    [SerializeField] private int dado1;
    [SerializeField] private int dado2;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.anyKeyDown)
        {
            dado1 = Random.Range(1, 7);
            dado2 = Random.Range(1, 7);

            if (dado1 > dado2)
            {
                pontos1 += 1;
            } if (dado2 > dado1)
            {
                pontos2 += 1;


            }



        }

        if (pontos1 == 3)
        {
            print("Jogador 1 ganhou!");

        } if(pontos2 == 3)
        {

            print("Jogador 2 ganhou!");

        }

    }
}
