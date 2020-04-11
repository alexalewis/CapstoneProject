import '../styles/SignInPage.scss'
import React, { useState } from 'react'
import { Link } from 'react-router-dom'
import NavBar from '../components/NavBar'
import Footer from '../components/Footer.jsx'
import axios from 'axios'

const SignInPage = () => {
  const [logInEmail, setLogInEmail] = useState('')
  const [logInPassword, setLogInPassword] = useState('')

  const logUserIntoApi = async () => {
    const resp = await axios.post('/auth/login', {
      email: logInEmail,
      password: logInPassword,
    })
    console.log(resp.data)
    // setToken(resp.data.token)
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
        <button onClick={logUserIntoApi}>
          <Link className="signInButton" to="/profile">
            Sign In
          </Link>
        </button>
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
