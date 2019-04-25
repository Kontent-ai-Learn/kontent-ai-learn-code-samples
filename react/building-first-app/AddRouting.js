// DocSection: building_first_react_app_add_routing
import React, { Component } from 'react';
import './App.css';

// Imports routing dependencies from react-router-dom and our components
import { BrowserRouter as Router, Route } from "react-router-dom";
import ArticleListing from './ArticleListing';
import ArticleView from './ArticleView';

class App extends Component {
  render() {
    return (
      <div className="App">
        <header className="App-header">
          <h1 className="App-title">Our blog</h1>
        </header>
        {/* Specifies routes and their components */}
        <Router>
          <div>
            <Route exact path="/" component={ArticleListing} />
            <Route path="/post/:slug" component={ArticleView} />
          </div>
        </Router>

      </div>
    );
  }
}

export default App;
// EndDocSection