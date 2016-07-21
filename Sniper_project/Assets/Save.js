#pragma strict
import System.Collections.Generic;

var gameName : String = "Sniper";
var flag : boolean = false;

function saveGame()
{
    LevelSerializer.SaveGame(gameName);
}

function loadGame()
{
    flag = true;
}

function OnGUI()
{
    if(flag)
    {
        var box : GUIStyle = "box";   
        GUILayout.BeginArea(Rect( Screen.width/2 - 200,Screen.height/2 - 300, 400, 600), box);

        GUILayout.BeginVertical(); 
        GUILayout.FlexibleSpace();

        for(var sg in LevelSerializer.SavedGames[LevelSerializer.PlayerName]) { 
            if(GUILayout.Button(sg.Caption)) { 
                LevelSerializer.LoadNow(sg.Data);
                Time.timeScale = 1;
                flag = false;
            } 
        }
        GUILayout.FlexibleSpace();
        GUILayout.EndVertical();
        GUILayout.EndArea();
    }
    
}