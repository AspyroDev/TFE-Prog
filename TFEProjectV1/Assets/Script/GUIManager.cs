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

    public GameObject ingredientObject;

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

        MeshFilter mesh = ingredientObject.GetComponent<MeshFilter>();
        Debug.Log(ingredientObject.GetComponent<MeshFilter>());
        if (ingredient[0].ModelName != "")
        {   
            Debug.Log(ingredient[0].ModelName);
            mesh.mesh = Resources.Load<Mesh>("Mesh/" + ingredient[0].ModelName);
        }
        else
        {
            mesh.mesh = Resources.Load<Mesh>("Mesh/" + "Cookie");
            ingredientObject.transform.Rotate(-90f, 0f, 0f);
        }
        ingredientObject.transform.Rotate(ingredient[0].XRotation, ingredient[0].YRotation, ingredient[0].ZRotation);

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
