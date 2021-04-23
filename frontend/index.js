var express = require('express')

var app = express();

app.listen(4334);

app.use(express.static('scripts'));

app.get('/', function(req, res) {
    res.sendFile(__dirname + '/index.html');
});