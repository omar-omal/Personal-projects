const express = require('express')
const router = express.Router()
const Author = require('../models/author')




router.get('/', async (req, res) => {
   
    //empty array to bring all values in case no search paramters exist
    let searchOptions = {}

    if (req.query.name != null && req.query.name != '') {
        
    //ReqExp is used to match the first letters and return a value based on that, 'i' means that the search is not case sensitive
    searchOptions.name = new RegExp(req.query.name, 'i')

    }
    
    try {
        const fetchedAuthor= await Author.find(searchOptions)
        res.render('authors',{author: fetchedAuthor})
        
    } catch {
        
        res.redirect('/')
    }
    
})

router.get('/new', (req, res)=>{

    res.render('addauthor')
})

router.post('/', (req, res,doc)=>{
    try {
        console.log(req.body)
        
        const author = new Author({name: req.body.name, lastName: req.body.lastname})
        author.save()
        res.redirect('author')
    } catch (error) {
        console.log(error)
    }
        
    
})


module.exports = router