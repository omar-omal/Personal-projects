const express = require('express')
const router = express.Router()
const Author = require('../models/author')


//All authors route
router.get('/',(req, res) =>{

    res.render('authors/index')
})

//New author route
router.get('/new',(req, res) =>{

    res.render('authors/new', {author: new Author()})
})

//Create author route
router.post('/',(req, res) =>{

    const author = new Author({name: req.body.name})
    author.save()

    res.redirect('authors')
})

module.exports = router