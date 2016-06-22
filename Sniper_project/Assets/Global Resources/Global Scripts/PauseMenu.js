#pragma strict
var PauseObject: GameObject;


function Start () 
{
	PauseObject.SetActive(false);
}

function Update () 
{
	if(Input.GetKeyDown(KeyCode.Escape))
	{
		ChangeTimeScale();
	}
}

function ChangeTimeScale()
{
	if(Time.timeScale == 1)
		PauseGame();
	else if(Time.timeScale == 0)
		ContinueGame();
}

function PauseGame()
{
	PauseObject.SetActive(true);
	Time.timeScale = 0;
}

function ContinueGame()
{
	PauseObject.SetActive(false);
	Time.timeScale = 1;
} 
