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
        res.render('author/index',{author: fetchedAuthor})
        
    } catch {
        
        res.redirect('/')
    }
    
})

router.get('/new', (req, res)=>{

    res.render('author/new')
})

router.post('/', (req, res,doc)=>{
    try {
        console.log(req.body)
        
        const author = new Author({name: req.body.name, lastName: req.body.lastname})
        author.save()
        res.redirect('authors')
    } catch (error) {
        console.log(error)
    }
        
    
})


//show author window
router.get('/:id', (req, res)=>{

    res.send('Show author' + req.params.id)
})



//show edit window
router.get('/:id/edit', (req, res)=>{

    res.send('Edit author' + req.params.id)
})

//update author
router.put('/:id', (req, res)=>{

    res.send('Update author' + req.params.id)
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