using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Npgsql;



public class DatabaseManager : MonoBehaviour
{
    string connString = "Host=127.0.0.1:5432;Username=postgres;Password=password;Database=tfe_database";

    // Start is called before the first frame update
    async void Start()
    {
        var dataSourceBuilder = new NpgsqlDataSourceBuilder(connString);
        var dataSource = dataSourceBuilder.Build();

        var conn = await dataSource.OpenConnectionAsync();

        await using (var cmd = new NpgsqlCommand("SELECT * FROM level01_shoppinglist;", conn))
        await using (var reader = await cmd.ExecuteReaderAsync())
        {
            while (await reader.ReadAsync())
                Debug.Log(reader.GetString(0) + " " + reader.GetString(1));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
