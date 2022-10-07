const express = require('express');
const path = require('path');
var bodyParser = require('body-parser');
const blobs = require(__dirname + '/blobs.js')

const app = express();

app.use('/build', express.static(path.join(__dirname, 'build')))
app.use('/templatedata', express.static(path.join(__dirname, 'templatedata')))
app.use('/Static', express.static(path.join(__dirname, 'Static')))


app.use(bodyParser.urlencoded({
    extended: false
 }));

 app.use(bodyParser.json());

app.get('/', (req, res) => {
    res.sendFile(path.join(__dirname + '/game.html'));
});

blobs.init(); 

app.get('/api/gethoney', (req, res) => {
    resultArray = blobs.blobsArray;

    res.json({
        blobArray: blobs.blobsArray
    });
});

app.post('/api/removehoney', (req, res) => {
    id = req.body.id;

    blobs.remove(id);

    res.send('OK!');
});

app.listen(3000, () => console.log('Gator app listening on port 3000!'));