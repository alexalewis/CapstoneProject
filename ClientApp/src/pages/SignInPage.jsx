import '../styles/SignInPage.scss'
import React, { useState, useEffect } from 'react'
import { Link } from 'react-router-dom'
import NavBar from '../components/NavBar'
import Footer from '../components/Footer.jsx'
import axios from 'axios'
import { useUserProfile } from '../components/UserProfileContext'

const SignInPage = () => {
  const [logInEmail, setLogInEmail] = useState('')
  const [logInPassword, setLogInPassword] = useState('')

  const { reloadUser } = useUserProfile()

  useEffect(() => {
    localStorage.removeItem('token')
  }, [])

  const logUserIntoApi = async () => {
    const resp = await axios.post('/auth/login', {
      email: logInEmail,
      password: logInPassword,
    })
    if (resp.status === 200) {
      console.log(resp.data)
      localStorage.setItem('token', resp.data.token)
      reloadUser()
    }
  }

  return (
    <>
      <NavBar />
      <h1 className="signInHeader">Welcome Back!</h1>
      <section className="signIn">
        <label htmlFor="email">Email</label>
        <input
          type="email"
          placeholder="Email Address"
          value={logInEmail}
          onChange={e => setLogInEmail(e.target.value)}
        ></input>
        <label htmlFor="text">Password</label>
        <input
          type="password"
          placeholder="Password"
          value={logInPassword}
          onChange={e => setLogInPassword(e.target.value)}
        ></input>
      </section>
      <section className="enterButton">
        <Link className="signInButton" to="/profile">
          <button onClick={logUserIntoApi}>Sign In</button>
        </Link>
      </section>
      <section className="account">
        <p>
          <Link className="noAccount" to="/sign-up">
            Don't have an account?
          </Link>
        </p>
      </section>
      <Footer />
    </>
  )
}

export default SignInPage
