using System;
using UnityEngine;
using UnityEngine.UI;

public class ClickMyGame : MonoBehaviour {

    public Text currencyText;
    public double alpha;
    public double coinsClickValue;
    public double coinsPerSecond;

    public Text coinsPerSecText;
    public Text clickUpgradeText;
    public Text productionUpgradeText;

    public double clickUpgradeCost;
    public double productionUpgradeCost;

    public void Start()
    {
        alpha = Math.Floor(alpha);
        coinsPerSecond = 0;
        coinsClickValue = 1;
        clickUpgradeCost = 10;
        productionUpgradeCost = 25;
    }
    public void Update()
    {
        currencyText.text = "Alpha: " + alpha.ToString("F0");
        coinsPerSecText.text = coinsPerSecond.ToString("F0") + " /s";
        clickUpgradeText.text = "Click Better\n" + clickUpgradeCost.ToString("F0") + " coins";
        productionUpgradeText.text = "Click Forever\n" + productionUpgradeCost.ToString("F0") + " coins";

        alpha += coinsPerSecond * Time.deltaTime;
    }
    public void Click()
    {
        alpha += coinsClickValue;
    }
    public void ClickBetterUpgrade()
    {
        if (alpha >= clickUpgradeCost)
        {
            alpha -= clickUpgradeCost;
            clickUpgradeCost *= 1.07;
            coinsClickValue++;
        }
    }
    public void ClickForeverUpgrade()
    {
        if (alpha >= productionUpgradeCost)
        {
            alpha -= productionUpgradeCost;
            productionUpgradeCost *= 1.07;
            coinsPerSecond ++;
        }
    }
}
