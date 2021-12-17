import styles from './authorization.module.scss'

const Authorization = () => {
    return (
        <div className={styles.general}>
            <div className={styles.map}>
                <h1>Create your emotion map</h1>
                <div className="logo"></div>
            </div>
            <div className={styles.form}>
                <div className={styles.sign_in}>
                    <button>Sign in with Google</button>
                    <div className={styles.or}>
                        <div className={styles.strip}></div>
                        <span>OR</span>
                        <div className={styles.strip}></div>
                    </div>
                    <div className={styles.inp_grup}>
                        <input type="email" name="" id="" placeholder="Email" />
                        <input type="password" name="" id="" placeholder="Password" />
                        <button>Sign in</button>
                    </div>
                </div>
                <div className={styles.sign_up}>
                    <span>Don't have an account? <a href="">Sign up</a></span>
                </div>
            </div>
        </div>
    )
}

export default Authorization
