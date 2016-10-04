var express = require('express');
var router = express.Router();
var Project = require('../models/project.model');
var Student = require('../models/student.model');

router.route('/:studentId/:projectId').post(function(req, res) {
  var studentId = req.params.studentId;
  var projectId = req.params.projectId;

  Project.findById(projectId, function(err, project) {
    if(err) {
      res.send(500, err);
    }
    project.studentIds.push(studentId);

    project.save(function(err, project) {
      if(err) {
        res.send(500, err);
      }
      Student.findById(studentId, function(err, student) {
        if(err) {
          res.send(500, err);
        }
        student.projectIds.push(projectId);

        student.save(function(err, student) {
          if(err) {
            res.send(500, err);
          }
          res.json(200);
        });
      });
    });
  });
});

module.exports = router;
