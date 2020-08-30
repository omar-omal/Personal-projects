const mongoose = require('mongoose')

const authorSchema = new mongoose.Schema({
    name:{type:String},
    lastName:{type:String},
    createdAt:{type:Date},
    hasBooks: {type: Boolean, default:false}

})
authorSchema.pre('save', function(next){

    
    if (this.createdAt == null) {
        
        this.createdAt = Date.now()
    }
    next()
})



 
    
   
  
  
   


module.exports = mongoose.model('Author', authorSchema)