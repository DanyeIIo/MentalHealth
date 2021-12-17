import styles from './mainPage.module.scss'

const MainPage = () => {
    return (
        <div className={styles.general}>
            <section>Track your emotions and improve your state in  three steps!</section>
            <section>
                <div>1.Answer simple questions</div>
                {/* test */}
            </section>
            <section>
                <div>2. Analyze what helps you with the help of an emotion map</div>
                {/* map */}
                {/* diagramma */}
            </section>
            <section>3. Improve the quality of your condition with the help of trainings, seminars and consultations with a psychologist!</section>
            <button className={styles.btn}>Start now!</button>
        </div>
    )
}

export default MainPage