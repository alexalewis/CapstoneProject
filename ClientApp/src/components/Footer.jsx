import React from 'react'
import '../styles/Footer.scss'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faTwitterSquare } from '@fortawesome/free-brands-svg-icons'
import { faFacebookSquare } from '@fortawesome/free-brands-svg-icons'

const Footer = () => {
  return (
    <>
      <footer>
        <section className="footerName">Endless Pawsibilities</section>
        <section className="socialMedia">
          <button className="twitter">
            <FontAwesomeIcon icon={faTwitterSquare} />
          </button>
          <button className="facebook">
            <FontAwesomeIcon icon={faFacebookSquare} />
          </button>
        </section>
      </footer>
    </>
  )
}

export default Footer
