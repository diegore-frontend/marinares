// Plugins

// Install comands:
// npm install --save-dev gulp
// npm install --save-dev gulp-concat
// npm install --save-dev gulp-livereload
// npm install --save-dev gulp-server-livereload
// npm install --save-dev gulp-notify
// npm install --save-dev gulp-stylus
// npm install --save-dev gulp-uglify
// npm install --save-dev nib

var gulp          = require('gulp');

	// Notifications
	header          = require('gulp-header'),
	notify          = require('gulp-notify'),
	pkg             = require('./package.json'),

	// Stylesheets
	stylus          = require('gulp-stylus'),
	rupture         = require('rupture'),
	nib             = require('nib'),

	// HTML modules
	nunjucksRender 	= require('gulp-nunjucks-render'),

	// Help
	plumber					= require('gulp-plumber'),

	// Server
	server          = require('gulp-server-livereload'),

	// Watching files
	livereload      = require('gulp-livereload');

	// Scripts
	uglify          = require('gulp-uglify'),
	concat          = require('gulp-concat'),

	filename  			= 'marinares-master',
	headerName 			= '#Marinares';


// Default Task with Stylus
gulp.task('default', function() {
	gulp.start('nunjucks','watch', 'webserver');
});

function fileHeader(title) {
	return [
		'/*!',
		title + ' - ' + pkg.version,
		'Copyright ©  ' + new Date().getFullYear() + ' - Diego Gutierrez',
		'Desarrollado por Esteban Serafin',
		'https://www.facebook.com/diego.salgado.9022',
		'*/\n'
	].join('\n')
}

const PATHS = {
    output: 'html',
    templates: 'Preprocess/nunjucks-templates/templates',
    pages: 'Preprocess/nunjucks-templates/pages',
    stylePath: 'Preprocess/stylus/',
    styleOut: 'Content/css/',
}

// writing up the gulp nunjucks task
gulp.task('nunjucks', function() {
	console.log('Rendering nunjucks files..');
	return gulp.src(PATHS.pages + '/**/*.+(html|js|css)')
	.pipe(plumber())
	.pipe(nunjucksRender({
		path: [PATHS.templates],
		watch: true,
	}))
	.pipe(gulp.dest(PATHS.output));
});

// Scripts Concatenating
// gulp.task('scripts', function() {
// 	return gulp.src(['Preprocess/scripts/*.js'])
// 	.pipe(plumber())
// 	.pipe(concat('jquery.vendors.js'))
// 	.pipe(notify({ message: 'Javascript concatenated! 🍻🍻' }))
// 	.pipe(header(fileHeader(headerName + ' - Vendors')))
// 	.pipe(uglify({
// 		preserveComments: 'some'
// 	}))
// 	.pipe(gulp.dest('Scripts/'));
// });

// Server Connection
gulp.task('webserver', function() {
	gulp.src('')
	.pipe(plumber())
	.pipe(server({
		host: '0.0.0.0',
		livereload: true,
		directoryListing: false,
		open: true,
		port: 8080
	}))
	.pipe(notify({ message: 'Server running! 🍻🍻' }));
});

// Watching Files Stylus
gulp.task('watch', function() {
	// Scripts
	gulp.watch('Preprocess/js/**/*.js', ['scripts']);

	// trigger Nunjucks render when pages or templates changes
  gulp.watch([PATHS.pages + '/**/*.+(html|js|css)', PATHS.templates + '/**/*.+(html|js|css)'], ['nunjucks'])
});
