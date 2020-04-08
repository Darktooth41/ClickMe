using UnityEngine;
using UnityEngine.UI;

public class ClickMyGame : MonoBehaviour {

    public Text currencyText;
    public double coins;
    public double coinsClickValue;

    public Text coinsPerSecText;
    public Text clickUpgradeText;
    public Text productionUpgradeText;

    public double coinsPerSecond;
    public double clickUpgradeCost;
    public double productionUpgradeCost;

    public void Start()
    {
        coins = 0;
        coinsPerSecond = 0;
        coinsClickValue = 1;
        clickUpgradeCost = 10;
        productionUpgradeCost = 100;
    }
    public void Update()
    {

        currencyText.text = "Coins: " + coins.ToString("F0");
        coinsPerSecText.text = coinsPerSecond.ToString("F0") + " /s";
        clickUpgradeText.text = "Click Better\n" + clickUpgradeCost.ToString("F0") + " coins";
        productionUpgradeText.text = "Click Forever\n" + productionUpgradeCost.ToString("F0") + " coins";

        coins += coinsPerSecond * Time.deltaTime;
    }
    public void Click()
    {
        coins += coinsClickValue;
    }
    public void ClickBetterUpgrade()
    {
        if (coins >= clickUpgradeCost)
        {
            coins -= clickUpgradeCost;
            clickUpgradeCost *= 1.07;
            coinsClickValue++;
        }
    }
    public void ClickForeverUpgrade()
    {
        if (coins >= productionUpgradeCost)
        {
            coins -= productionUpgradeCost;
            productionUpgradeCost *= 1.07;
            coinsPerSecond ++;
        }
    }
}
