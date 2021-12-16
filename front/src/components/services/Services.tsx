import styles from './services.module.scss'
import schedule from '/public/assets/schedule.png'

const Services = () => {

    return (
        <div className={styles.general}>
            <section className={styles.list}>
                <p className={styles.headlines}>Mental Health provides services such as:</p>
                <ul>
                    <li>Consultation with a psychologist</li>
                    <li>Trainings</li>
                    <li>Seminars</li>
                </ul>
            </section>
            <section>
                <p className={styles.headlines}>Consultation</p>
                <p>A consultation with a psychologist takes place face-to-face at any time convenient for you and on any topic convenient for you.</p>
                <button className={styles.btn}>Enroll</button>
            </section>
            <section>
                <p className={styles.headlines}>Trainings</p>
                <p>Trainings are conducted for several people and are aimed at working in a group. Trainings are held on various topics. You can find out more about the time in <span className={styles.link}>the schedule</span>.</p>
            </section>
            <section>
                <p className={styles.headlines}>Seminars</p>
                <p>Seminars are held on various topics for a group of people. The seminars are aimed at providing theoretical knowledge. You can find out more about the time in <span className={styles.link}>the schedule</span>.</p>
            </section>
            <section>
                <p className={styles.headlines}>The schedule</p>
                {/* calendar */}
                <img src={schedule} alt="" width={'80%'} />
                {/* calendar */}
                <button className={styles.btn}>Enroll</button>
            </section>
        </div>
    )
}

export default Services