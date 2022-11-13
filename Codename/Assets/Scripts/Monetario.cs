using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
    [SerializeField] private GameObject painelCantAfford;
    [SerializeField] private GameObject painelAFK;

    [SerializeField] private GameObject Pillar;
    [SerializeField] private GameObject Pillar2;
    double moneySoma = 0.00;
    int clicou = 0;
    int clicouComprar = 0;
    int qtdeClicouP = 0;
    int qtdePilares = 0;

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

    public void PosicionouPillar()
    {
        qtdeClicouP = 0;
        qtdePillar.text = "" + qtdeClicouP;
        buttonPlaceP.SetActive(false);
        Pillar.SetActive(true);
        Pillar2.SetActive(true);
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
            workName.text = "Advogado";
        }
        else if (clicou == 85)
        {
            workLevel.text = "Lv. 7";
            workName.text = "Policial";
        }
    }

    public void FecharAviso()
    {
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
        
    }

    
}
