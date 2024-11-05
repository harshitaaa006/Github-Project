const path = require('path');

module.exports = {
    entry: './src/index.js', // Path to your main React file
    output: {
        path: path.resolve(__dirname, 'wwwroot/dist'), // Output directory
        filename: 'bundle.js', // The output file for your React code
    },
    module: {
        rules: [
            {
                test: /\.(js|jsx)$/, // Apply Babel on JS and JSX files
                exclude: /node_modules/,
                use: {
                    loader: 'babel-loader',
                    options: {
                        presets: ['@babel/preset-env', '@babel/preset-react'],
                },
            },
        ],
    },
    resolve: {
        extensions: ['.js', '.jsx'], // Resolve these extensions
    },
    devServer: {
        static: './wwwroot',
            directory: path.join(__dirname, 'wwwroot'),
        },
        compress: true,
        port: 9000, // Port for the dev server
    },
};
