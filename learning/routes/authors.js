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
        //console.log(fetchedAuthor)
        res.render('author/index',{author: fetchedAuthor})
        
    } catch {
        
        res.redirect('/')
    }
    
})

router.get('/new', (req, res)=>{
    try {
        
        res.render('author/new')
    } catch (error) {
        res.redirect('/')
        console.log(error)
    }
})

router.post('/', async (req, res)=>{
    try {
        console.log(req.body)
        let hasValue = req.body.hasBooks
        let checked
        if (hasValue == 'on') {
            checked = true
        }
        const author = new Author({name: req.body.name, lastName: req.body.lastname, hasBooks: checked})
        
        await author.save()
        res.redirect('authors')
    } catch (error) {
        console.log(error)
    }
        
    
})


//show author window
router.get('/:id', async (req, res)=>{
    try {
        const author = await Author.findById(req.params.id)
        res.render('author/show', {author: author})
        
    } catch (error) {
        res.redirect('/')
    }
    //res.send('Show author' + req.params.id)
})  



//show edit window
router.get('/:id/edit', async (req, res)=>{
    try {
            const author = await Author.findById(req.params.id)
            res.render('author/edit', {author: author})

    } catch {
        res.redirect('/authors')
    }
    //res.send('Edit author' + req.params.id)
})

//update author
router.put('/:id', async (req, res)=>{

    let author
    try {
        let hasValue = req.body.hasBooks
        let checked
        if (hasValue == 'on') {
            checked = true
        }
        console.log(req.body)
        author = await Author.findById(req.params.id)
        author.name = req.body.name
        author.lastName = req.body.lastName
        author.hasBooks = checked
        await author.save()
        res.redirect('/authors')
    } catch{
        if (author == null) {
            
            res.redirect('/')
        } 
    } 

    //res.send('Update author' + req.params.id)
})


router.delete('/:id', async (req, res)=>{

    let author = await Author.findById(req.params.id)
    try{
        await author.remove()
        res.redirect('/authors')

    }catch
    {
        console.log('Did not delete the record!')
    }

    //res.send('Delete author' + req.params.id)
})


module.exports = router