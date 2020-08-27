const express = require('express');
const bodyParser = require('body-parser')
const app = express()
const expressLayouts = require('express-ejs-layouts')
//The routes are being linked to the correct routing file
const indexRouter = require('./routes/index')
const authorsRouter = require('./routes/authors')




app.use(express.static('public'))
app.use(expressLayouts)
app.use(bodyParser.urlencoded({extended: false}))

//Set the type of viewengine which is ejs
app.set('view engine', 'ejs') 

//setting the default views folder
app.set('views', __dirname + '/views') 

//Change the layout default to be inside a folder
app.set('layout', 'layouts/layout') 



//Connect to and initialize database
const mongoose = require('mongoose');
mongoose.connect(`mongodb://localhost/mydatabase`, {useNewUrlParser: true, useUnifiedTopology: true})
const db = mongoose.connection
db.on('error', error => console.error(error))
db.once('open', () => console.log('Connected to Mongoose'))



/*This is the first step in routing, the request is matched with 
the correct route below then sent to the correct route*/
app.use('/', indexRouter)
app.use('/authors', authorsRouter)



app.listen(process.env.PORT || 3000);