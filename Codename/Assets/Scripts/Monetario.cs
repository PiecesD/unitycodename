using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Monetario : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI moneyAmount;
    [SerializeField] TextMeshProUGUI workLevel;
    [SerializeField] TextMeshProUGUI workName;
    [SerializeField] TextMeshProUGUI qtdePillar;
    [SerializeField] TextMeshProUGUI qtdeWall;
    [SerializeField] TextMeshProUGUI qtdeFloor;
    [SerializeField] TextMeshProUGUI qtdeWindow;
    [SerializeField] TextMeshProUGUI qtdeDoor;
    [SerializeField] TextMeshProUGUI qtdeRoof;

    [SerializeField] private GameObject buttonPurchaseP;
    [SerializeField] private GameObject buttonPlaceP;
    [SerializeField] private GameObject buttonPurchaseW;
    [SerializeField] private GameObject buttonPlaceW;
    [SerializeField] private GameObject buttonPurchaseF;
    [SerializeField] private GameObject buttonPlaceF;
    [SerializeField] private GameObject buttonPurchaseWi;
    [SerializeField] private GameObject buttonPlaceWi;
    [SerializeField] private GameObject buttonPurchaseD;
    [SerializeField] private GameObject buttonPlaceD;
    [SerializeField] private GameObject buttonPurchaseR;
    [SerializeField] private GameObject buttonPlaceR;

    [SerializeField] private GameObject buttonPlaceMoon;
    [SerializeField] private GameObject buttonPlaceSun;

    [SerializeField] private GameObject painelCantAfford;
    [SerializeField] private GameObject painelAFK;

    [SerializeField] private GameObject Pillar;
    [SerializeField] private GameObject Pillar2;
    [SerializeField] private GameObject Wall;
    [SerializeField] private GameObject Floor;
    [SerializeField] private GameObject Roof;
    [SerializeField] private GameObject Roof2;
    [SerializeField] private GameObject Roof3;
    [SerializeField] private GameObject Window;
    [SerializeField] private GameObject Door;

    [SerializeField] private GameObject Moon;
    [SerializeField] private GameObject Sun;
    [SerializeField] private GameObject Day;
    [SerializeField] private GameObject Night;

    double moneySoma = 0.00;
    int clicou = 0;
    int clicouComprar = 0;

    int qtdeClicouP = 0;
    int qtdePilares = 0;

    int qtdeClicouW = 0;
    int qtdeParedes = 0;

    int qtdeClicouF = 0;
    int qtdeChao = 0;

    int qtdeClicouR = 0;
    int qtdeTelhado = 0;

    int qtdeClicouD = 0;
    int qtdePorta = 0;

    int qtdeClicouWi = 0;
    int qtdeJanelas = 0;
    double random;

    public Button botaoMenor30;
    public Button botaoEntre3080;
    public Button botaoMaior80;

    public void ComprouPillar()
    {
        if (qtdePilares == 0)
        {
            clicouComprar = clicouComprar + 1;
            if (moneySoma >= 60)
            {
                moneySoma = moneySoma - 60;
                qtdeClicouP++;
                qtdePillar.text = "" + qtdeClicouP;
                if (qtdeClicouP == 4)
                {
                    qtdePilares = 1;
                    buttonPurchaseP.SetActive(false);
                    buttonPlaceP.SetActive(true);
                }
            }
            else
            {
                painelCantAfford.SetActive(true);
            }
        }
        else
        {

        }
    }

    public void ComprouWall()
    {
        if (qtdeParedes == 0)
        {
            clicouComprar = clicouComprar + 1;
            if (moneySoma >= 120)
            {
                moneySoma = moneySoma - 120;
                qtdeClicouW++;
                qtdeWall.text = "" + qtdeClicouW;
                if (qtdeClicouW == 4)
                {
                    qtdeParedes = 1;
                    buttonPurchaseW.SetActive(false);
                    buttonPlaceW.SetActive(true);
                }
            }
            else
            {
                painelCantAfford.SetActive(true);
            }
        }
        else
        {

        }
    }

    public void ComprouFloor()
    {
        if (qtdeChao == 0)
        {
            clicouComprar = clicouComprar + 1;
            if (moneySoma >= 85)
            {
                moneySoma = moneySoma - 85;
                qtdeClicouF++;
                qtdeFloor.text = "" + qtdeClicouF;
                if (qtdeClicouF == 1)
                {
                    qtdeChao = 1;
                    buttonPurchaseF.SetActive(false);
                    buttonPlaceF.SetActive(true);
                }
            }
            else
            {
                painelCantAfford.SetActive(true);
            }
        }
        else
        {

        }
    }

    public void ComprouRoof()
    {
        if (qtdeTelhado == 0)
        {
            clicouComprar = clicouComprar + 1;
            if (moneySoma >= 285)
            {
                moneySoma = moneySoma - 285;
                qtdeClicouR++;
                qtdeRoof.text = "" + qtdeClicouR;
                if (qtdeClicouR == 1)
                {
                    qtdeTelhado = 1;
                    buttonPurchaseR.SetActive(false);
                    buttonPlaceR.SetActive(true);
                }
            }
            else
            {
                painelCantAfford.SetActive(true);
            }
        }
        else
        {

        }
    }

    public void ComprouDoor()
    {
        if (qtdePorta == 0)
        {
            clicouComprar = clicouComprar + 1;
            if (moneySoma >= 75)
            {
                moneySoma = moneySoma - 75;
                qtdeClicouD++;
                qtdeDoor.text = "" + qtdeClicouD;
                if (qtdeClicouD == 2)
                {
                    qtdePorta = 1;
                    buttonPurchaseD.SetActive(false);
                    buttonPlaceD.SetActive(true);
                }
            }
            else
            {
                painelCantAfford.SetActive(true);
            }
        }
        else
        {

        }
    }

    public void ComprouWindow()
    {
        if (qtdeJanelas == 0)
        {
            clicouComprar = clicouComprar + 1;
            if (moneySoma >= 97)
            {
                moneySoma = moneySoma - 97;
                qtdeClicouWi++;
                qtdeWindow.text = "" + qtdeClicouWi;
                if (qtdeClicouWi == 3)
                {
                    qtdeJanelas = 1;
                    buttonPurchaseWi.SetActive(false);
                    buttonPlaceWi.SetActive(true);
                }
            }
            else
            {
                painelCantAfford.SetActive(true);
            }
        }
        else
        {

        }
    }


    public void PosicionouPillar()
    {
        qtdeClicouP = 0;
        qtdePillar.text = "" + qtdeClicouP;
        buttonPlaceP.SetActive(false);
        Pillar.SetActive(true);
        Pillar2.SetActive(true);
    }

    public void PosicionouWall()
    {
        qtdeClicouW = 0;
        qtdeWall.text = "" + qtdeClicouW;
        buttonPlaceW.SetActive(false);
        Wall.SetActive(true);
    }

    public void PosicionouFloor()
    {
        qtdeClicouF = 0;
        qtdeFloor.text = "" + qtdeClicouF;
        buttonPlaceF.SetActive(false);
        Floor.SetActive(true);
    }

    public void PosicionouRoof()
    {
        qtdeClicouR = 0;
        qtdeRoof.text = "" + qtdeClicouR;
        buttonPlaceR.SetActive(false);
        Roof.SetActive(true);
        Roof2.SetActive(true);
        Roof3.SetActive(true);
    }

    public void PosicionouWindow()
    {
        qtdeClicouWi = 0;
        qtdeWindow.text = "" + qtdeClicouWi;
        buttonPlaceWi.SetActive(false);
        Window.SetActive(true);
    }

    public void PosicionouDoor()
    {
        qtdeClicouD = 0;
        qtdeDoor.text = "" + qtdeClicouD;
        buttonPlaceD.SetActive(false);
        Door.SetActive(true);
    }

    public void Trabalhar()
    {
        moneySoma = moneySoma + 9.00;
        clicou = clicou + 1;

        Debug.Log("Trabalhou!");
        moneyAmount.text = "R$ " + moneySoma + ",00";

        if (clicou < 10)
        {
            workLevel.text = "Lv. 1";
            workName.text = "Jardineiro";
        }
        else if (clicou == 20)
        {
            workLevel.text = "Lv. 2";
            workName.text = "Cuidador de Idosos";
        }
        else if (clicou == 25)
        {
            workLevel.text = "Lv. 3";
            workName.text = "Cuidador de Pets";
        }
        else if (clicou == 30)
        {
            workLevel.text = "Lv. 4";
            workName.text = "Vendedor";
        }
        else if (clicou == 45)
        {
            workLevel.text = "Lv. 5";
            workName.text = "Enfermeiro";
        }
        else if (clicou == 65)
        {
            workLevel.text = "Lv. 6";
            workName.text = "Policial";
        }
        else if (clicou == 85)
        {
            workLevel.text = "Lv. 7";
            workName.text = "Advogado";
        }
        else if (clicou == 105)
        {
            workLevel.text = "Lv. 8";
            workName.text = "Médico";
        }
        else if (clicou == 125)
        {
            workLevel.text = "Lv. 9";
            workName.text = "Desembargador";
        }
        else if (clicou == 145)
        {
            workLevel.text = "Lv. 10 - Máximo";
            workName.text = "Pleno";
        }
    }

    public void TornarDia()
    {
        Moon.SetActive(false);
        Sun.SetActive(true);
        Day.SetActive(true);
        Night.SetActive(false);
        buttonPlaceSun.SetActive(false);
        buttonPlaceMoon.SetActive(true);
    }

    public void TornarNoite()
    {
        Moon.SetActive(true);
        Sun.SetActive(false);
        Night.SetActive(true);
        Day.SetActive(false);
        buttonPlaceSun.SetActive(true);
        buttonPlaceMoon.SetActive(false);
    }

    public void FecharAviso()
    {
        random = Random.Range(0, 90);
        moneySoma = moneySoma + random;
        painelCantAfford.SetActive(false);
        painelAFK.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moneyAmount.text = "R$ " + moneySoma + ",00";
    }

    
}
