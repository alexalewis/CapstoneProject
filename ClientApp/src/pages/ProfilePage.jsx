import React, { useEffect, useState } from 'react'
import { Link } from 'react-router-dom'
import axios from 'axios'
import { useUserProfile } from '../components/UserProfileContext'
import '../styles/ProfilePage.scss'
import Footer from '../components/Footer'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faPaw } from '@fortawesome/free-solid-svg-icons'
import { faFileAlt } from '@fortawesome/free-solid-svg-icons'
import { faMapMarkerAlt } from '@fortawesome/free-solid-svg-icons'

const ProfilePage = () => {
  const { user } = useUserProfile()

  return (
    <>
      <section className="profilePageHeader">
        <nav>
          <ul className="navUl">
            <li>
              <Link to="/" className="linkToHome">
                Home
              </Link>
            </li>
          </ul>
        </nav>

        <section className="profileHeader">
          <h2 className="name">
            {user.firstName} {user.lastName}
          </h2>
          <p className="city">
            <FontAwesomeIcon icon={faMapMarkerAlt} className="locationIcon" />
            {user.zipcode}
          </p>
        </section>
      </section>
      <section className="profilePicture"></section>

      <section className="icons">
        <section className="iconLayout">
          <button className="favorites">
            <FontAwesomeIcon icon={faPaw} />
          </button>
          <p>Favorites</p>
        </section>
        <section className="iconLayout">
          <button className="applications">
            <FontAwesomeIcon icon={faFileAlt} />
          </button>
          <p>Applications</p>
        </section>
      </section>
      <section className="aboutYou">
        <h2>About You</h2>
        <section>
          <ul className="aboutYouThings">
            <li>Thing</li>
            <li>Thing</li>
            <li>Thing</li>
            <li>Thing</li>
            <li>Thing</li>
            <li>Thing</li>
            <li>Thing</li>
          </ul>
        </section>
      </section>
      <Footer />
    </>
  )
}

export default ProfilePage
