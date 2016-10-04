var mongoose = require('mongoose');

var Schema = mongoose.Schema;

var projectSchema = new Schema({
	name: {
		type: 'string', // string, number, boolean, array, mixed
		required: true
	},
	description: {
		type: 'string',
		required: false
	},
	studentIds: [ {type : mongoose.Schema.ObjectId, ref : 'student'} ]
});

module.exports = mongoose.model('project', projectSchema);
