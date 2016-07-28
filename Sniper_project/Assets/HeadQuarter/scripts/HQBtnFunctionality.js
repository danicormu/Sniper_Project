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
    Application.LoadLevel("IntroGinebra");
}

function moscou()
{
    Application.LoadLevel("IntroMoscu");
}

function grozny()
{
    Application.LoadLevel("escena");
}

