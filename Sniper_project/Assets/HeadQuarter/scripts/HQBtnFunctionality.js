#pragma strict

var menu: GameObject;

function Start()
{
    menu.SetActive(false);
}

function QuitGameOnClick()
{
    Application.LoadLevel("MainMenu");
} 

function GoToStore()
{
    Application.LoadLevel("DealerStore");
}

function newGame()
{
    menu.SetActive(true);
} 

function ginger()
{
    Application.LoadLevel("Ginebra");
}

function moscou()
{
    Application.LoadLevel("Scenerio3");
}

function grozny()
{
    Application.LoadLevel("escena");
}

