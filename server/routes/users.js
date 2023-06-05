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
  const dummyData = {
    name: req.params.id,
    date: '2013-01-01T00:00:00',
    age: 30,
  };
  res.json(dummyData);
});

module.exports = router;
