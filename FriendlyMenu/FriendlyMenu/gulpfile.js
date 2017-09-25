/// <binding BeforeBuild='compile:sass' ProjectOpened='watch:sass' />
/*
This file is the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. https://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');
var sass = require('gulp-sass');
var rename = require('gulp-rename');

var webroot = "./wwwroot/";
var paths = {
    scss: webroot + "css/**/*.scss",
    scssDest: webroot + "css/"
};

gulp.task('compile:sass', function () {
    // place code for your default task here
    gulp.src(paths.scss, { base: "./" })
        .pipe(sass().on('error', sass.logError))
        .pipe(rename({ dirname: '' }))
        .pipe(gulp.dest(webroot + "/css/"));
});

gulp.task("compile", ["compile:sasss"]);

gulp.task('watch:sass', function () {
    gulp.watch(paths.scss, ['compile:sass']);
});