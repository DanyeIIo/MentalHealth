import styles from './navbar.module.scss';
import {
  BrowserRouter as Router,
  Switch,
  Route,
  IndexRoute,
  Link,
  NavLink,
} from 'react-router-dom';
const Navbar = () => {
  return (
    <nav className={styles.nav}>
      <span>
        <a href="/emotions">Emotion Map</a>
      </span>
      <span>
        <a href="/services">Services</a>
      </span>
      <span>
        <a href="/about">About Us</a>
      </span>
      {/* <span className={styles.sign_in}>Sign In</span> */}
    </nav>
  );
};

export default Navbar;
