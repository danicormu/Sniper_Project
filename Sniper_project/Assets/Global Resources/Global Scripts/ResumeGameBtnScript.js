#pragma strict

var PauseObject: GameObject;

function ResumeGameBtnClick()
{
    Time.timeScale = 1;
    PauseObject.SetActive(false);
} 