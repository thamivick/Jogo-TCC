using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneMenagement;

public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject PainelOpcoes;

    public void Jogar()
    {
        ScaneManager.LoadScene("Jogo")
    }

    public void abrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void fecharOpcoes()
    {

    }

    public void sairJogo()
    {

    }
}

