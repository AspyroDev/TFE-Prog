using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Npgsql;



public class DatabaseManager
{
    string connString = "Host=127.0.0.1:5432;Username=postgres;Password=password;Database=tfe_database";

    private static DatabaseManager databaseInstance;
    private NpgsqlConnection connection;

    private DatabaseManager() 
    {
        NpgsqlDataSourceBuilder dataSourceBuilder = new NpgsqlDataSourceBuilder(connString);
        NpgsqlDataSource dataSource = dataSourceBuilder.Build();

        NpgsqlConnection conn = dataSource.OpenConnection();
        this.connection = conn;
    }

    public NpgsqlConnection getConnection() 
    {
        return connection;
    }

    public static DatabaseManager getInstance()
    {
        if (databaseInstance == null)
        {
            databaseInstance = new DatabaseManager();
        }

        return databaseInstance;
    }

    public List<Level01Ingredient> GetLevel01Ingredients()
    {
        List<Level01Ingredient> ingredientSet = new List<Level01Ingredient>();
        
        using (var cmd = new NpgsqlCommand("SELECT * FROM level01_shoppinglist;", connection))
        using (var reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                Level01Ingredient templateIngredient = new Level01Ingredient();
                templateIngredient.Name = reader.GetString(0);
                templateIngredient.Category = reader.GetString(1);
                templateIngredient.SizeUnit = reader.GetString(2);
                templateIngredient.MinSize = reader.GetInt32(3);
                templateIngredient.MaxSize = reader.GetInt32(4);
                templateIngredient.MinPrice = reader.GetInt32(5);
                templateIngredient.MaxPrice = reader.GetInt32(6);
                templateIngredient.ModelName = reader.GetString(7);

                ingredientSet.Add(templateIngredient);
            }
        }

        return ingredientSet;
    }
}
