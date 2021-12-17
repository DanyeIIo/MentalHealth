import React from 'react';
import './App.css';
import Header from '../Header/Header';
import About from '../about/About';
import Services from '../services/Services';
import Authorization from '../authorization/Authorization';
import Registration from '../registration/Registration';
import MainPage from '../mainPage/MainPage';
import Emotion from '../Emotion/Emotions';
import 'bootstrap/dist/css/bootstrap.min.css';
import background from '/public/assets/clouds.png'
import {
  BrowserRouter as Router,
  Switch,
  Route,
  IndexRoute,
  Link,
} from 'react-router-dom';

const App = () => {
  return (
    <div style={{backgroundImage: `url("${background}")`,height:'100%'}}>
      <Header />
      <Router>
        <div className="" >
          {/* <nav className="navbar navbar-expand navbar-dark bg-dark">
  
          <div className="navbar-nav ml-auto">
          <li className="nav-item">
              <Link to={"/emotions"} className="nav-link">
                Emotion Map
              </Link>
            </li>
            <li className="nav-item">
              <Link to={"/services"} className="nav-link">
                Services
              </Link>
            </li>
            <li className="nav-item">
              <Link to={"/about"} className="nav-link">
                About
              </Link>
            </li>
          </div>
        </nav> */}
          <Switch>
            <Route exact path="/services" component={Services} />
            <Route exact path="/about" component={About} />
            <Route exact path="/emotions" component={Emotion} />
            <Route exact path="/authorization" component={Authorization} />
            <Route exact path="/registration" component={Registration} />
            <Route exact path="/" component={MainPage} />
            <Route exact path="/mainPage" component={MainPage} />
            {/* <Route
                exact
                path="/emotion"
                render={(props) => (
                  <Emotions
                    {...props}
                    user={user}
                  />
                )}
              /> */}
            <Route render={() => <h3>Not found</h3>} />
          </Switch>
        </div>
      </Router>
    </div>
  );
};

export default App;
