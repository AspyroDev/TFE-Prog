using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class GUIManager : MonoBehaviour
{
    public Level01Constructor dbManager;

    private TextMeshProUGUI nameText;
    private TextMeshProUGUI categoryText;
    private TextMeshProUGUI sizeUnitText;
    private TextMeshProUGUI sizeText;
    private TextMeshProUGUI priceText;

    [SerializeField] private GameObject ShoppingList;

    void objectSelection()
    {
        //Debug.Log(ingredientObject.transform.childCount);
        //Debug.Log(ingredientObject.transform.GetComponentsInChildren<Transform>());
        for (int i = 0; i < ShoppingList.transform.childCount; i++)
        {
            printIngredientValues(ShoppingList.transform.GetChild(i));
        }
    }

    void printIngredientValues(Transform item) 
    {
        List<Level01Ingredient> ingredient = dbManager.getIngredients(1);
        
        // Get Name
        item.GetChild(1).GetComponentInChildren<TextMeshProUGUI>().text = ingredient[0].Name.ToString();

        //Get Model
        MeshFilter mesh = item.GetChild(0).GetComponentInChildren<MeshFilter>();
        if (ingredient[0].ModelName != "")
        {   
            mesh.mesh = Resources.Load<Mesh>("Mesh/" + ingredient[0].Name.ToString());
            //mesh.mesh = Resources.Load<Mesh>("Mesh/" + "Cookie");
            item.GetChild(0).transform.Rotate(ingredient[0].XRotation, ingredient[0].YRotation, ingredient[0].ZRotation);
        }
        else
        {
            mesh.mesh = Resources.Load<Mesh>("Brocoli");
            // mesh.mesh = Resources.Load<Mesh>();
            item.GetChild(0).transform.Rotate(-90f, 0f, 0f);
        }

        

        // Get Category
        //item.GetChild(1).GetComponent<TextMeshProUGUI>().text = ingredient[0].Category.ToString();

        // Get SizeUnit
        //item.GetChild(2).GetComponent<TextMeshProUGUI>().text = ingredient[0].SizeUnit.ToString();

        // Get Size
        //item.GetChild(3).GetComponent<TextMeshProUGUI>().text = 
        //    Random.Range(ingredient[0].MinSize, ingredient[0].MaxSize).ToString();
        
        // Get Price
        // item.GetChild(1).GetComponent<TextMeshProUGUI>().text = 
        //     Random.Range(ingredient[0].MinPrice, ingredient[0].MaxPrice).ToString();

        // Get Model
        
    }

    // Start is called before the first frame update
    void Start()
    {
        objectSelection();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
