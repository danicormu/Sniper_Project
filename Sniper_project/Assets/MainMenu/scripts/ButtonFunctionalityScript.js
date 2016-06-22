#pragma strict

var Enable = false;
var SettingsMenu : GameObject;
var CreditsObject: GameObject;

function Update()
{
    
}

function Start()
{
    SettingsMenu.SetActive(false);
    CreditsObject.SetActive(false);
}

function NewGameOnClick()
{
   Application.LoadLevel("HeadQuarter");
}

function LoadGameOnClick()
{
    Application.LoadLevel("HeadQuarter");
}

function SettingsOnClick()
{
   
    CreditsObject.SetActive(false);
    SettingsMenu.SetActive(true);
}

function CreditsOnClick()
{
    SettingsMenu.SetActive(false);
    CreditsObject.SetActive(true);
}

function MultiplayerOnClick()
{
	Application.LoadLevel("Multiplayer");
}

function HowToPlayOnclick()
{
	Application.LoadLevel("Demo");
}

function ExitSettingsOnClick()
{
     SettingsMenu.SetActive(false);
}

function ExitCreditsOnClick()
{
    CreditsObject.SetActive(false);
}