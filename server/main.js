const express = require('express');

const app = express();

app.get('/', (req, res) => {
  res.send('hello, world!');
});

app.listen('port', (req, res) => {
  console.log(`Example app listening on port ${port}`);
});
