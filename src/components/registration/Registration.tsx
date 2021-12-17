import styles from './registration.module.scss'

const Registration = () => {
    return (
        <div className={styles.general}>
            <div className={styles.map}>
                <h1>Create your emotion map</h1>
                <div className={styles.logo}></div>
            </div>
            <div className={styles.form}>
                <div className={styles.sign_in}>
                    <div className={styles.create_text}>Create Account</div>
                    <div className={styles.inp_grup}>
                        <input type="text" placeholder="Full Name" className={styles.main} />
                        <div className={styles.birthday}>
                            <span>Birthday</span>
                            <div className={styles.select_grp}>
                                <select name="" id="">
                                    <option value="">Mount</option>
                                </select>
                                <select name="" id="">
                                    <option value="">Day</option>
                                </select>
                                <select name="" id="">
                                    <option value="">Year</option>
                                </select>
                            </div>
                        </div>
                        <input type="email" name="" id="" placeholder="Email" className={styles.main} />
                        <input type="password" name="" id="" placeholder="Password" className={styles.main} />
                        <input type="password" placeholder="Confirm password" className={styles.main} />
                        <button>Sign Up</button>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default Registration