const path = require('path');
module.exports = {
    entry: './wwwroot/source/app.js',
    output: {
        path: path.resolve(__dirname, 'wwwroot/dist'),
        filename: 'bundle.js'
    },
    resolve: {
        alias: {
            vue: 'vue/dist/vue.js'
        },
        extensions: ['.js', '.vue']
    }
};