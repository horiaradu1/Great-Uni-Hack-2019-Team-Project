var choices = document.getElementsByClassName("skin");

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
	}
	choices[imageNumber].style.borderStyle="solid";
	choices[imageNumber].style.borderColor="red";
	if(imageNumber==0)
	{
		document.getElementById("mySkin").src="BeePictures/beeyellow.png";
	}
	else if(imageNumber==1)
	{
		document.getElementById("mySkin").src="BeePictures/beeblue.png";
	}
	else if(imageNumber==2)
	{
		document.getElementById("mySkin").src="BeePictures/beered.png";
	}
	else if(imageNumber==3)
	{
		document.getElementById("mySkin").src="BeePictures/beegreen.png";
	}
}
function goBack() {
	document.getElementById("overlay").style.display="none";
	document.getElementById("pop-up-skin-form").style.display="none";
}
