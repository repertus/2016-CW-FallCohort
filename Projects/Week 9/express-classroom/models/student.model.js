var mongoose = require('mongoose');

var Schema = mongoose.Schema;

var studentSchema = new Schema({
  firstName: {
    type: 'string',
    required: true
  },
  lastName: {
    type: 'string',
    required: true
  },
  email: {
    type: 'string',
    required: true
  },
  phone: {
    type: 'string',
    required: true
  },
  projectIds: [ {type : mongoose.Schema.ObjectId, ref : 'project'} ]
});

module.exports = mongoose.model('student', studentSchema);
