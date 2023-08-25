using System.Collections;
using System.Collections.Generic;

public class ScenarioEntity {

    private int Id {get; set;}
    private string Name {get; set;}
    private int ThemeId {get; set;}
    private int ExerciceId {get; set;}

    public ScenarioEntity(int id, string name, int themeId, int exerciceId) {
        Id = id;
        Name = name;
        ThemeId = theme;
        ExerciceId = exerciceId;
    }

    public ScenarioEntity() {
        Id = 0;
        Name = "";
        ThemeId = 0;
        ExerciceId = 0:
    }
}