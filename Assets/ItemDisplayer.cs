using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplayer : MonoBehaviour
{
    public GameItem Item;
    public Image ArtworkItem;
    public Text NameItemText;
    public Text ValueItemText;

    private void Start()
    {
        ValueItemText.text = Item.Value.ToString() + "G";
        NameItemText.text = Item.Name;
        ArtworkItem.sprite = Item.Icon;

    }

}
