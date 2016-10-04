var express = require('express');
var router = express.Router();
var Student = require('../models/student.model');

router.route('/')

			// GET: api/students
			.get(function(req, res) {
				Student.find(function(err, students) {
					if(err) {
						return res.send(500, err);
					}

					res.json(students);
				});
			})

			// POST: api/students
			.post(function(req, res) {
				var student = new Student();

				student.name = req.body.name;
				student.description = req.body.description;

				student.save(function(err, student) {
					if(err) {
						return res.send(500, err);
					}

					return res.json(student);
				});
			});

router.route('/:id')

			// GET: api/students/1;
			.get(function(req, res) {
				Student.findById(req.params.id)
							 .populate('projectIds')
							 .exec(function(err, student) {
								 	if(err) {
				 						return res.send(500, err);
				 					}

				 					res.json(student);
							 });

				// Student.findById(req.params.id, function(err, student) {
				// 	if(err) {
				// 		return res.send(500, err);
				// 	}
				//
				// 	res.json(student);
				// });
			})

			// PUT: api/students/1
			.put(function(req, res) {
				Student.findById(req.params.id, function(err, student) {
					if(err) {
						return res.send(500, err);
					}

					student.name = req.body.name;
					student.description = req.body.description;

					student.save(function(err, student) {
						if(err) {
							return res.send(500, err);
						}

						res.json(200);
					});
				});
			})

			// DELETE: api/students/1
			.delete(function(req, res) {
				Student.remove({ _id: req.params.id }, function(err, student) {
					if(err) {
						return res.send(500);
					}

					res.json(student);
				});
			});

module.exports = router;
