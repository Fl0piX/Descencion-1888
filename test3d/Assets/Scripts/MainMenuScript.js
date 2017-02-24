#pragma strict

var SphereEnable : boolean = true;
var SphereGameObject : GameObject;

function LOAD_SCENE(){
Application.LoadLevel("test3d");
}

function SPHERE_ENABLE(){
SphereEnable = !SphereEnable;
}

function Update(){
if(SphereEnable == true){
SphereGameObject.SetActive(true);
}else{
SphereGameObject.SetActive(false);
}
}

function QUIT_GAME(){
Application.Quit();
}