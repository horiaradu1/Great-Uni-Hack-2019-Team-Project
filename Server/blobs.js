const sha256 = require('sha256'); 

blobsArray = []

targetNum = 10

maxDif = 50.0
 
createBlob = () => {
    newId = sha256(Math.random().toString()).toString();
    newPosX = (Math.random() * (- maxDif - maxDif) + maxDif).toFixed(4)
    newPosY = (Math.random() * (- maxDif - maxDif) + maxDif).toFixed(4)
    newScore = Math.floor(Math.random() * 3) + 1;

    return {id: newId, posX: newPosX, posY: newPosY, score: newScore};
}

init = () => {
    while (blobsArray.length < targetNum) { 
        blobsArray.push(createBlob());
    }
}

remove = (id) => {
    for (i  = 0; i < blobsArray.length; ++ i) {
        if (blobsArray[i].id == id) {
            blobsArray.splice(i, 1);
            break;
        }
    }
    blobsArray.push(createBlob());
}

module.exports = {
    init: init,
    blobsArray: blobsArray,
    remove: remove
}
