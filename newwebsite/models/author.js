const mongoose = require('mongoose')

//Here we define the table collums
const authorSchema = new mongoose.Schema({

    name: {
            type:String,
            required:true
    }
})


//Another way to right it would have been

//const authorSchema = new mongoose.Schema({name:String})




//Below we create a table called Author
module.exports = mongoose.model('Author', authorSchema)