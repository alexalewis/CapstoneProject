import React from 'react'
import { Link } from 'react-router-dom'
import '../styles/ProfilePage.scss'
import Footer from '../components/Footer'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faPaw } from '@fortawesome/free-solid-svg-icons'
import { faFileAlt } from '@fortawesome/free-solid-svg-icons'
import { faMapMarkerAlt } from '@fortawesome/free-solid-svg-icons'

const ProfilePage = () => {
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
          <h2 className="name">Your Name</h2>
          <p className="city">
            <FontAwesomeIcon icon={faMapMarkerAlt} className="locationIcon" />
            Your city
          </p>
        </section>
      </section>
      <section className="profilePicture">
        <img className="profileImage"></img>
      </section>

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
            <li>Thing</li>
          </ul>
        </section>
      </section>
      <Footer />
    </>
  )
}

export default ProfilePage
