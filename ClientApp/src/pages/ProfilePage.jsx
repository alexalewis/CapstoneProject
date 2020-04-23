import React, { useState, useEffect } from 'react'
import { Link } from 'react-router-dom'
import { Redirect } from 'react-router-dom'
import { useUserProfile } from '../components/UserProfileContext'
import '../styles/ProfilePage.scss'
import Footer from '../components/Footer'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faPaw } from '@fortawesome/free-solid-svg-icons'
import { faFileAlt } from '@fortawesome/free-solid-svg-icons'
import { faMapMarkerAlt } from '@fortawesome/free-solid-svg-icons'
import { faHeart } from '@fortawesome/free-solid-svg-icons'

const ProfilePage = () => {
  const { user, reloadUser } = useUserProfile()
  const [shouldRedirect, setShouldRedirect] = useState(false)

  useEffect(() => {
    if (!user) {
      reloadUser()
    }
  }, [])

  const getMatches = async () => {
    setShouldRedirect(true)
  }

  if (shouldRedirect) {
    return <Redirect to="/matches" />
  }

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
            <FontAwesomeIcon icon={faHeart} />
          </button>
          <p>Favorites</p>
        </section>
        <section className="iconLayout">
          <button className="matching" onClick={getMatches}>
            <FontAwesomeIcon icon={faPaw} />
          </button>
          <p>Start Matching</p>
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
