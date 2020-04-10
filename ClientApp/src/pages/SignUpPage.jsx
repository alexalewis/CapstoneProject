import React from 'react'
import { Link } from 'react-router-dom'
import Footer from '../components/Footer.jsx'
import '../styles/SignUpPage.scss'

const SignUpPage = () => {
  return (
    <>
      <section>
        <h1 className="signUpHeader">Create an Account</h1>
      </section>
      <section className="signUp">
        <label for="firstName">First Name</label>
        <input type="text" name="firstname"></input>
        <label for="lastName">Last Name</label>
        <input type="text" name="lastName"></input>
        <label for="emailAddress">Email Address</label>
        <input type="email" name="emailAddress"></input>
        <label for="password">Password</label>
        <input type="password"></input>
      </section>
      <section className="enterButton">
        <button>
          <Link className="signUpButton" to="/questionnaire">
            Sign Up
          </Link>
        </button>
      </section>

      <Footer />
    </>
  )
}

export default SignUpPage
