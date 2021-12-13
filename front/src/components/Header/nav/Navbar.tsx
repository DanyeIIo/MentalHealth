import styles from './navbar.module.scss'

const Navbar = () => {
    return (
        <nav className={styles.nav}>
            <span>Emotion Map</span>
            <span>Services</span>
            <span>About Us</span>
        </nav>
    )
}

export default Navbar
