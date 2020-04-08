import '../styles/SignInPage.scss'
import React from 'react'
import { Link } from 'react-router-dom'
import NavBar from '../components/NavBar'

const SignInPage = () => {
  return (
    <>
      <NavBar />
      {/* logo, nav bar */}
      <h1 className="signInHeader">Welcome Back!</h1>
      <section className="signIn">
        <label for="email">Email</label>
        <input type="email" placeholder="Email Address"></input>
        <label for="text">Password</label>
        <input type="text" placeholder="Password"></input>
      </section>
      <section className="enterButton">
        <button>
          <Link className="signInButton" to="/profile">
            Sign In
          </Link>
        </button>
      </section>
      <section className="account">
        <p>
          <Link className="noAccount" to="/match">
            Don't have an account?
          </Link>
        </p>
      </section>
    </>
  )
}

export default SignInPage
