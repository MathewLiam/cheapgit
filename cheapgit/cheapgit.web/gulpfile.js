var gulp = require('gulp'),
    sass = require('gulp-sass'),
    cssmin = require("gulp-cssmin"),
    rename = require("gulp-rename"),
    webpack = require("webpack-stream");

gulp.task('min', function (done) {
    gulp.src('assets/scss/style.scss')
        .pipe(sass().on('error', sass.logError))
        .pipe(cssmin())
        .pipe(rename({
            suffix: ".min"
        }))
        .pipe(gulp.dest('wwwroot/assets/css'));
    done();
});

gulp.task('compile:productexplorer', function (done) {
    gulp.src('UI/Apps/cheapgit.productexplorer/src/index.js')
        .pipe(webpack({
            output: {
                filename: '[name].min.js',
            },
            module: {
                rules: [
                    {
                        test: /\.js$/,
                        loader: 'babel-loader'
                    },
                    {
                        test: /\.css/,
                        loader: "css-loader"
                    },
                    {
                        test: /\.(scss|sass)/,
                        use: [
                            "sass-loader",
                            "style-loader"
                        ]
                    }
                ]
            }
        }))
        .pipe(gulp.dest('wwwroot/js/productexplorer'));
    done();
})

gulp.task("compile", gulp.parallel(["min", "compile:productexplorer"]));
gulp.task("default", gulp.series("compile"));
