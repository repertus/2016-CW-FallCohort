var express = require('express');
var router = express.Router();
var Project = require('../models/project.model');

router.route('/')

			// GET: api/projects
			.get(function(req, res) {
				Project.find(function(err, projects) {
					if(err) {
						return res.send(500, err);
					}

					res.json(projects);
				});
			})

			// POST: api/projects
			.post(function(req, res) {
				var project = new Project();

				project.name = req.body.name;
				project.description = req.body.description;

				project.save(function(err, project) {
					if(err) {
						return res.send(500, err);
					}

					return res.json(project);
				});
			});

router.route('/:id')

			// GET: api/projects/1;
			.get(function(req, res) {
				Project.findById(req.params.id)
							 .populate('studentIds')
							 .exec(function(err, project) {
								 	if(err) {
				 						return res.send(500, err);
				 					}

				 					res.json(project);
							 });

				// Project.findById(req.params.id, function(err, project) {
				// 	if(err) {
				// 		return res.send(500, err);
				// 	}
				//
				// 	res.json(project);
				// });
			})

			// PUT: api/projects/1
			.put(function(req, res) {
				Project.findById(req.params.id, function(err, project) {
					if(err) {
						return res.send(500, err);
					}

					project.name = req.body.name;
					project.description = req.body.description;

					project.save(function(err, project) {
						if(err) {
							return res.send(500, err);
						}

						res.json(200);
					});
				});
			})

			// DELETE: api/projects/1
			.delete(function(req, res) {
				Project.remove({ _id: req.params.id }, function(err, project) {
					if(err) {
						return res.send(500);
					}

					res.json(project);
				});
			});

module.exports = router;
