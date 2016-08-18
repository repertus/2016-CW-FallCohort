var gulp = require('gulp');
var gutil = require('gulp-util');
var inject = require('gulp-inject');

gulp.task('default', function() {
	gutil.log('hello world!');
});

gulp.task('inject', function() {
	var sources = gulp.src(['./src/app/**/*.js', './src/styles/**/*.css']);

	gulp.src('./src/index.html')
			.pipe(inject(sources))
			.pipe(gulp.dest('./src'));
});