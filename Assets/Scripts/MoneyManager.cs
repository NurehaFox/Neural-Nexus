using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager instance;

    private void Awake()
    {
        instance = this;
    }

    public int currentMoney;

    // Start is called before the first frame update
    void Start()
    {
        UIController.instance.moneyText.text = currentMoney.ToString();
    }

    public void GiveMoney(int amountToGive)
    {
        currentMoney += amountToGive;

        UIController.instance.moneyText.text = currentMoney.ToString();
    }

    public bool SpendMoney(int amountToSpend)
    {
        bool canSpend = false;

        if(amountToSpend <= currentMoney)
        {
            canSpend = true;

            currentMoney -= amountToSpend;
        }

        UIController.instance.moneyText.text = currentMoney.ToString();

        return canSpend;
    }
}
