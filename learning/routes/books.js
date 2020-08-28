const express = require('express')
const router = express.Router()
//const Author = require('../models/author')
const Book = require('../models/book')

router.get('/', async (req, res)=>{

    try {
        const fetchedBooks = await Book.find({})
        res.render('books/index', {book:fetchedBooks})
    } catch {
        
        console.log('Books failed to load')
    }
})

router.get('/new', (req, res)=>{

    res.render('books/new')
})

router.post('/', (req, res)=>{
    try {
        const book = new Book({name:req.body.name, type:req.body.type})
        book.save()
        console.log(req.body)
        res.redirect('/')
    } catch{
        console.log('Error during saving!')
    }
    
}) 


module.exports = router