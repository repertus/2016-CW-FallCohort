/* Mongoose configuration */
var mongoose = require('mongoose');
mongoose.connect('mongodb://localhost:27017/classroom');

/* Express configuration */
var express = require('express');
var bodyParser = require('body-parser');

var projectRoute = require('./routes/project.route');
var studentRoute = require('./routes/student.route');
var assignmentRoute = require('./routes/assignment.route');

var app = express();
app.use(bodyParser.json());

var apiRouter = express.Router();

apiRouter.use('/projects', projectRoute);
apiRouter.use('/students', studentRoute);
apiRouter.use('/assignment', assignmentRoute);

app.use(apiRouter);

app.listen(8080, function() {
	console.log('Listening on port 8080');
});
