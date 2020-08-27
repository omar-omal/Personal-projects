
if(process.env.NODE_ENV !== 'production'){

    require('dotenv').config()
}

const express = require('express');
const app = express()
const expressLayouts = require('express-ejs-layouts')
const bodyParser = require('body-parser')


const indexRouter = require('./route/index')
const authorRouter = require('./route/authors')


app.set('view engine', 'ejs')
app.set('views', __dirname + '/views')
app.set('layout', 'layouts/layout')

app.use(expressLayouts)
app.use(express.static('public'))
app.use(bodyParser.urlencoded({limit: '10mb', extended:false}))

//instatiate the database of MongoDb
const mongoose = require('mongoose')
//defining the connection string to the database based on the enviroment it is in
mongoose.connect(process.env.DATABASE_URL,{useNewUrlParser:true, useUnifiedTopology: true})
//check whether the db is connected or not
const db = mongoose.connection
db.on('error', error => console.error(error))
db.once('open', () => console.log('Connected to Mongoose'))



app.use('/', indexRouter)
app.use('/authors', authorRouter)



app.listen(process.env.PORT || 3000)