const express = require('express')
const router = express.Router()
const Author = require('../models/author')
const Book = require('../models/book')

router.get('/', async (req, res)=>{

    try {
        const fetchedBooks = await Book.find({})
        res.render('books/index', {book:fetchedBooks})
    } catch {
        
        console.log('Books failed to load')
    }
})

router.get('/new', async (req, res)=>{
    
    try {
        
        const fetchedAuthor = await Author.find({})
        res.render('books/new', {author : fetchedAuthor})
        

    } catch {
        console.log('Could not bring author information')
    }
})

router.post('/', (req, res)=>{
    try {
        const book = new Book({name:req.body.name, type:req.body.type, author: req.body.author})
        book.save()
        console.log(req.body)
        res.redirect('/')
    } catch{
        console.log('Error during saving!')
    }
    
}) 


module.exports = router