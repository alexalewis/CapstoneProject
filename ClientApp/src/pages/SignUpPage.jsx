import React, { useState, useEffect } from 'react'
import axios from 'axios'
import NavBar from '../components/NavBar'
import { Redirect } from 'react-router-dom'
import Footer from '../components/Footer.jsx'
import '../styles/SignUpPage.scss'

const SignUpPage = () => {
  const [firstName, setFirstName] = useState('')
  const [lastName, setLastName] = useState('')
  const [email, setEmail] = useState('')
  const [password, setPassword] = useState('')
  const [shouldRedirect, setShouldRedirect] = useState(false)

  // useEffect(() => {
  //   localStorage.removeItem('token')
  // })

  const sendNewUserToApi = async () => {
    const resp = await axios.post('/auth/signup', {
      firstName: firstName,
      lastName: lastName,
      email: email,
      password: password,
    })
    console.log(resp.data)
    if (resp.status === 200) {
      localStorage.setItem('token', resp.data.token)
      setShouldRedirect(true)
    }
  }

  if (shouldRedirect) {
    return <Redirect to="/questionnaire" />
  }

  return (
    <>
      <NavBar />
      <section>
        <h1 className="signUpHeader">Create an Account</h1>
      </section>
      <section className="signUp">
        <label htmlFor="firstName">First Name</label>
        <input
          className="signUpInput"
          type="text"
          name="firstName"
          value={firstName}
          onChange={e => setFirstName(e.target.value)}
        ></input>
        <label htmlFor="lastName">Last Name</label>
        <input
          className="signUpInput"
          type="text"
          name="lastName"
          value={lastName}
          onChange={e => setLastName(e.target.value)}
        ></input>
        <label htmlFor="emailAddress">Email Address</label>
        <input
          className="signUpInput"
          type="email"
          name="emailAddress"
          value={email}
          onChange={e => setEmail(e.target.value)}
        ></input>
        <label htmlFor="password">Password</label>
        <input
          className="signUpInput"
          type="password"
          name="password"
          value={password}
          onChange={e => setPassword(e.target.value)}
        ></input>
      </section>
      <section className="submitButton">
        <button onClick={sendNewUserToApi}>Sign Up</button>
      </section>

      <Footer />
    </>
  )
}

export default SignUpPage
