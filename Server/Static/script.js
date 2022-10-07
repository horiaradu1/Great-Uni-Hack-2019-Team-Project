var choices = document.getElementsByClassName("skin");

var unityInstance = undefined;

var beeColor = 3;

document.getElementById("game").style.display = "none";

function openSkins() {
    document.getElementById("overlay").style.display = "block";
    document.getElementById("pop-up-skin-form").style.display = "block";
}

function pickSkin(imageNumber) {
	var i;
	for(i=0;i<choices.length;i++)
	{
		choices[i].style.borderStyle="none";
		choices[i].style.borderColor="none";
		choices[i].style.opacity="0.7";
	}
	choices[imageNumber].style.borderStyle="solid";
	choices[imageNumber].style.borderColor="red";
	choices[imageNumber].style.opacity="1";
	if(imageNumber==0)
	{
		beeColor = 3;
		document.getElementById("mySkin").src="Static/BeePictures/beeyellowp.png";
	}
	else if(imageNumber==1)
	{
		beeColor = 0;
		document.getElementById("mySkin").src="Static/BeePictures/beebluep.png";
	}
	else if(imageNumber==2)
	{
		beeColor = 2;
		document.getElementById("mySkin").src="Static/BeePictures/beeredp.png";
	}
	else if(imageNumber==3)
	{
		beeColor = 1;
		document.getElementById("mySkin").src="Static/BeePictures/beegreenp.png";
	}
}


function goBack() {
	document.getElementById("overlay").style.display="none";
	document.getElementById("pop-up-skin-form").style.display="none";
}

function changeScene() {
	document.getElementById("myForm").style.display = "none";
	document.getElementById("connectButton").style.display = "none";

	document.getElementById("game").style.display = "block";

	unityInstance = UnityLoader.instantiate("unityContainer", "Build/Release.json", {onProgress: UnityProgress});
	setTimeout(function () {unityInstance.SendMessage("WebManager", "chooseBeeColor", beeColor);}, 3000);
}