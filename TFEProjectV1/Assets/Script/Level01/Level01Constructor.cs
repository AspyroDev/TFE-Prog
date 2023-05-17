using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level01Constructor : MonoBehaviour
{
    GetLevel01Data lv01;
    // Start is called before the first frame update

    List<Level01Ingredient> getIngredients(int quantity)
    {
        List<Level01Ingredient> ingredients = lv01.GetIngredients();
        List<Level01Ingredient> toReturn = new List<Level01Ingredient>();

        for (int index = 0; index < quantity; index++)
        {
            int rdm = Random.Range(0, ingredients.Count);
            toReturn.Add(ingredients[rdm]);
            ingredients.RemoveAt(rdm);
        }
        return toReturn;
    }

    void Start()
    {
        lv01 = new GetLevel01Data();
        List<Level01Ingredient> ingredients = getIngredients(5);
        for (int index = 0; index < 100; index++)
        {
            ingredients = getIngredients(5);          
            foreach (Level01Ingredient ing in ingredients)
            {
                Debug.Log(index + " " + ing.ToString());
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
