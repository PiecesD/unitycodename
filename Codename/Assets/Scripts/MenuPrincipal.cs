using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPrincipal : MonoBehaviour
{
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelMenuPrincipal;
    [SerializeField] private GameObject painelMenuOpcoes;
    [SerializeField] private GameObject painelMenuDicas;
    [SerializeField] private GameObject painelMenuGaleria;
    [SerializeField] private GameObject painelMenuTutorial;
    [SerializeField] private GameObject painelMenuProfessor;
    [SerializeField] private GameObject painelMenuCreditos;
    [SerializeField] private GameObject painelMenuLoginGame;
    [SerializeField] private GameObject painelMenuLoginTeacher;

    public void AbrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelMenuPrincipal.SetActive(false);
        painelMenuOpcoes.SetActive(true);
    }

    public void FecharOpcoes()
    {
        painelMenuOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
        painelMenuPrincipal.SetActive(true);
    }

    public void AbrirDicas()
    {
        painelMenuInicial.SetActive(false);
        painelMenuPrincipal.SetActive(false);
        painelMenuDicas.SetActive(true);
    }

    public void FecharDicas()
    {
        painelMenuDicas.SetActive(false);
        painelMenuInicial.SetActive(true);
        painelMenuPrincipal.SetActive(true);
    }

    public void AbrirGaleria()
    {
        painelMenuInicial.SetActive(false);
        painelMenuPrincipal.SetActive(false);
        painelMenuGaleria.SetActive(true);
    }

    public void FecharGaleria()
    {
        painelMenuGaleria.SetActive(false);
        painelMenuInicial.SetActive(true);
        painelMenuPrincipal.SetActive(true);
    }

    public void AbrirTutorial()
    {
        painelMenuInicial.SetActive(false);
        painelMenuPrincipal.SetActive(false);
        painelMenuTutorial.SetActive(true);
    }

    public void FecharTutorial()
    {
        painelMenuTutorial.SetActive(false);
        painelMenuInicial.SetActive(true);
        painelMenuPrincipal.SetActive(true);
    }

    public void AbrirRelatorio()
    {
        painelMenuInicial.SetActive(false);
        painelMenuPrincipal.SetActive(false);
        painelMenuLoginTeacher.SetActive(false);
        painelMenuProfessor.SetActive(true);
    }

    public void FecharRelatorio()
    {
        painelMenuProfessor.SetActive(false);
        painelMenuInicial.SetActive(true);
        painelMenuPrincipal.SetActive(true);
    }

    public void AbrirCreditos()
    {
        painelMenuInicial.SetActive(false);
        painelMenuPrincipal.SetActive(false);
        painelMenuCreditos.SetActive(true);
    }

    public void FecharCreditos()
    {
        painelMenuCreditos.SetActive(false);
        painelMenuInicial.SetActive(true);
        painelMenuPrincipal.SetActive(true);
    }

    public void AbrirLogin()
    {
        painelMenuInicial.SetActive(false);
        painelMenuPrincipal.SetActive(false);
        painelMenuLoginGame.SetActive(true);
    }

    public void FecharLogin()
    {
        painelMenuInicial.SetActive(true);
        painelMenuPrincipal.SetActive(true);
        painelMenuLoginGame.SetActive(false);
    }

    public void AbrirLoginT()
    {
        painelMenuInicial.SetActive(false);
        painelMenuPrincipal.SetActive(false);
        painelMenuLoginTeacher.SetActive(true);
    }

    public void FecharLoginT()
    {
        painelMenuInicial.SetActive(true);
        painelMenuPrincipal.SetActive(true);
        painelMenuLoginTeacher.SetActive(false);
    }




    public void SairJogo()
    {
        Debug.Log("Saiu");
        Application.Quit();
    }
}
