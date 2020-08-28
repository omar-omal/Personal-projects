const express = require('express')
const router = express.Router()
const Author = require('../models/author')
const Book = require('../models/book')



router.get('/', async (req, res) => {
    try {
        const fetchedBooks = await Book.find({})
        const fetchedAuthors = await Author.find({})
        
        res.render('index', {author:fetchedAuthors, book: fetchedBooks})
    } catch{
    
        console.log('Error at homepage')
    }


})


module.exports = router