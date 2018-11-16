var gulp = require('gulp');
var concat = require('gulp-concat');
var cssmin = require('gulp-cssmin');
var browserSync = require('browser-sync').create();


gulp.task('sync', function() {
    browserSync.init({
        proxy: 'localhost:5000'
    });
    gulp.watch('./Styles/**/*.css', ['css']);
});

gulp.task('js', function() {
    return gulp.src([
        './node_modules/bootstrap/dist/js/bootstrap.min.js',
        './node_modules/jquery/dist/jquery.min.js',
    ])
    .pipe(gulp.dest('wwwroot/js/'))
    .pipe(browserSync.stream());
});

gulp.task('css', function() {
    return gulp.src([
        './node_modules/bootstrap/dist/css/bootstrap.min.css',
        './Styles/site.css',
    ])
    .pipe(concat('site.min.css'))
    .pipe(cssmin())
    .pipe(gulp.dest('wwwroot/css'))
    .pipe(browserSync.stream());
});

gulp.task('watch', function() {
    gulp.watch('./Styles/**/*.css', ['css']);
});