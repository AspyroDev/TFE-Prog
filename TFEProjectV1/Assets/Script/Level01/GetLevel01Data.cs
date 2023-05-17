using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetLevel01Data
{
    private DatabaseManager dbManager {get; set; }

    public GetLevel01Data()
    {
        dbManager = DatabaseManager.getInstance();
    }
    // Start is called before the first frame update
    public List<Level01Ingredient> GetIngredients()
    {
        return dbManager.GetLevel01Ingredients();

    }
}
