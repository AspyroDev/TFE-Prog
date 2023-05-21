using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class GUIManager : MonoBehaviour
{
    public Level01Constructor dbManager;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI categoryText;
    public TextMeshProUGUI sizeUnitText;
    public TextMeshProUGUI sizeText;
    public TextMeshProUGUI priceText;

    void printIngredientValues() 
    {
        List<Level01Ingredient> ingredient = dbManager.getIngredients(1);
        
        // Get Name
        nameText.text = ingredient[0].Name.ToString();

        // Get Category
        categoryText.text = ingredient[0].Category.ToString();

        // Get SizeUnit
        sizeUnitText.text = ingredient[0].SizeUnit.ToString();

        // Get Size
        sizeText.text = 
            Random.Range(ingredient[0].MinSize, ingredient[0].MaxSize).ToString();
        
        // Get Price
        priceText.text = 
            Random.Range(ingredient[0].MinPrice, ingredient[0].MaxPrice).ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        printIngredientValues();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
