import styles from './header.module.scss'
import Navbar from './nav/Navbar';

const Header = () => {
    return (
        <header className={styles.header}>
            <h1>Mental Health</h1>
            <Navbar />
        </header>
    )
}

export default Header;
