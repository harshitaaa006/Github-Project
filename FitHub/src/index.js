import React from 'react';
import ReactDOM from 'react-dom';
import ActivityPage from './ActivityPage'; // Adjust the path accordingly

ReactDOM.render(
    <React.StrictMode>
        <ActivityPage />
    </React.StrictMode>,
    document.getElementById('root') // Make sure this matches the div ID in your Razor Page
);
