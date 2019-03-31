using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> items;
    private int money;

    private void Start()
    {
        items = Constants.startItems.ToList();
        money = Constants.startMoney;
    }
}
