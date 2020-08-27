const mongoose = require('mongoose')

const authorSchema = new mongoose.Schema({
    name:String,
    lastName:String,
    createdAt:Date

})
authorSchema.pre('save', function(next){

    
    if (this.createdAt == null) {
        
        this.createdAt = Date.now()
    }
    next()
})



 
    
   
  
  
   


module.exports = mongoose.model('Author', authorSchema)