const express = require('express')
const router = express.Router()

//Default route
router.get('/',(req, res) =>{

    res.render('index')
})

module.exports = router