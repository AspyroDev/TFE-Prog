using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataFetcher : MonoBehaviour
{

    private DatabaseManager dbManager {get; set; }
    
    [SerializeField] private int ExpertiseNeeded;
    [SerializeField] private int PlayerExpertise;
    [SerializeField] private string ThemeName = "Calcul littéral";
    [SerializeField] private string ExerciceType = "Problème Mathématique";
    
    // Start is called before the first frame update
    void Start()
    {
        dbManager = DatabaseManager.getInstance();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
