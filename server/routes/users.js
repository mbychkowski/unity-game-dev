const express = require('express');
const router = express.Router();

/* GET users listing. */
router.get('/', function (req, res, next) {
  // res.send('respond with a resource');

  const dummyData = {
    name: 'michael',
    date: '2013-01-01T00:00:00',
    age: 99,
  };
  res.json(dummyData);
});

router.get('/:id', function (req, res, next) {
  var dummyData = {
    userid: req.params['id'],
    username: 'mbski',
    wins: 18,
    losses: 1000,
    someArray: [
      { name: 'foo', value: 2.5 },
      { name: 'bar', value: 7.1 },
      { name: 'baz', value: 9000.001 },
    ],
  };
  res.json(dummyData);
});

module.exports = router;
