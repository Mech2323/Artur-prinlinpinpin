using System;
using UnityEngine;

public class Guerradedados : MonoBehaviour
{

    [SerializeField] private int vida;
    [SerializeField] private int atk;
    [SerializeField] private int def;
    private int defdado;
    private int dados;

    [SerializeField] private int vidaCPU = 1;
    [SerializeField] private int atkCPU = 1;
    [SerializeField] private int defCPU = 1;

    private int dadosCPU = 1;
    private int atributosiarandom;
    private int defdadoCPU;

    private int vez;


    private Boolean game = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

        if (vida + atk + def < 1)
        {
            print("Selecione seus atributos.");
        }
        else if (vida + atk + def > 5)
        {
            print("Ós atributos só podem somar até 5");
        }
        else
        {
            dadoCPU();
            if (atributosiarandom == 1)
            {
                vidaCPU++;
            }
            if (atributosiarandom == 2)
            {
                atkCPU++;
            }
            if (atributosiarandom == 3)
            {
                defCPU++;
            }
            dadoCPU();
            if (atributosiarandom == 1)
            {
                vidaCPU++;
            }
            if (atributosiarandom == 2)
            {
                atkCPU++;
            }
            if (atributosiarandom == 3)
            {
                defCPU++;
            }




        }


    }

    // Update is called once per frame
    void Update()
    {
        if (game == true)
        {

            turnoplayer();

            if (vida <= 0)
            {
                print("perdeu");
                game = false;
            }
            else if (vidaCPU <= 0)
            {
                print("Ganhou");
                game = false;
            }
        }
        if (game == true)
        {
            turnoCPU();

            if (vida <= 0)
            {
                print("perdeu");
                game = false;
            }
            else if (vidaCPU <= 0)
            {
                print("Ganhou");
                game = false;
            }
        
        }










    }

    void dado()
    {
        dados = UnityEngine.Random.Range(1, 7);
    }

    void dadoCPU()
    {
        atributosiarandom = UnityEngine.Random.Range(1, 4);
    }

    void turnoplayer()
    {
       
        dado();
        if (dados % 2 == 0)
        {
            dado();
            if (atk + dados - def - defdadoCPU > 0)
            {
                vidaCPU -= atk + dados - def - defdadoCPU;
            }
            defdadoCPU = 0;
            print("Atacou! Dano inflingido: " + (atk + dados) + ", vida atual: " + vida +", vida inimigo: " + vidaCPU);
           
        }
        else
        {
            dado();
            defdado = dados;
            defdadoCPU = 0; 
            print("Defendeu! Defesa: " + (def + dados));
        }
    }
    void turnoCPU()
    {
        dado();
        if (dados % 2 == 0)
        {
            dado();
            if(atkCPU + dados - def - defdado > 0)
            {
            vida -= atkCPU + dados - def - defdado;
            }
            
            defdado = 0;
            print("Atacado! Dano sofrido: " + (atkCPU + dados) + ", vida: " + vida + ", vida inimiga: " + vidaCPU);
        }
        else
        {
            dado();
            defdadoCPU += dados;
            defdado = 0;
            print("Defesa inimiga! Defesa: " +(defCPU  + dados));
        }
    }
}
