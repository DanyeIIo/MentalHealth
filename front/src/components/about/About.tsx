import brains from '/public/assets/brains.png'
import styles from './about.module.scss'
import { useEffect } from 'react'

const About = () => {

    const getResource = (url: string): Promise<any> => {
        return new Promise((resolve, reject) => {
            fetch(url)
                .then(res => resolve(res.json()))
                .catch(err => reject(err))
        })
    }

    const getFilmlist = () => {
        return getResource(`https://mentalhealthapi2.azurewebsites.net/Account/register`)
    }

    useEffect(() => {
        getFilmlist().then(res => console.log(res))
    })

    return (<div className={styles.general}>
        <div className={styles.topic}>Mental Health is a company that helps users solve mental health problems, understand themselves and improve their quality of life. </div>
        <img src={brains} alt="Brains" />
        <div className={styles.provide}>We provide services with which you can solve problems such as:</div>
        <div className={styles.services}>
            <div className={styles.brd_boot}>Communication problems</div>
            <div className={styles.mid_div}>Self-doubt</div>
            <div className={styles.brd_boot}>Anxiety and insomnia</div>
            <div>Phobias, panic attacks</div>
            <div className={styles.mid_div2}>Procrastination</div>
            <div>Depression, chronic fatigue</div>
        </div>
        <div>Find out more about our services!</div>
        <button>Learn more</button>
    </div>)
}

export default About