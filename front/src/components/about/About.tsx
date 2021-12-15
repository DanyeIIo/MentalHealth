import brains from '/public/assets/brains.png'
import styles from './about.module.scss'

const About = () => {
    return (<div className={styles.general}>
        <div className={styles.topic}>Mental Health is a company that helps users solve mental health problems, understand themselves and improve their quality of life. </div>
        <img src={brains} alt="Brains" />
        <div className={styles.provide}>We provide services with which you can solve problems such as:</div>
        <div className={styles.services}>
            <div>Communication problems</div>
            <div>Self-doubt</div>
            <div>Anxiety and insomnia</div>
            <div>Phobias, panic attacks</div>
            <div>Procrastination</div>
            <div>Depression, chronic fatigue</div>
        </div>
        <div>Find out more about our services!</div>
        <button>Learn more</button>
    </div>)
}

export default About