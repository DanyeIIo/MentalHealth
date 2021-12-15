import styles from './header.module.scss'
import Navbar from './nav/Navbar';
import logo from '/public/assets/logo.png'

const Header = () => {
    return (
        <header className={styles.header}>
            <img src={logo} alt="logo" />
            <Navbar />
        </header>
    )
}

export default Header;
