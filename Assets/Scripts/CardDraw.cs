using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CardDraw : MonoBehaviour
{

    public CardSpawn lootDropTable;

    public int numCards;


    private void OnValidate()
    {
        lootDropTable.validateTable();
    }

    public void drawCard()
    {
        CardItem selectedItem = lootDropTable.PickLootItem();
        GameObject selectedCard = Instantiate(selectedItem.item);
        selectedCard.transform.position = new Vector3(0, 6f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
