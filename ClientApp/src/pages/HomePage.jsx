import '../styles/HomePage.scss'
import React from 'react'
import NavBar from '../components/NavBar'

const HomePage = () => {
  return (
    <>
      <header className="header">
        <NavBar />
        <h1 className="appHeading">Name of the App</h1>
        <h2 className="tagline">Your furry friend is waiting</h2>
      </header>
      <section className="aboutUs">
        <h3 className="aboutUsHeading">About Us</h3>
        <p>
          We know how it is. You search what kind of animal you want to rescue
          and then <span class="boom">BOOM</span>, 100 pages of animals to
          choose from. We also know how difficult it can be to see all of their
          faces and make a choice. We want to make it easier and less
          overwhelming for you.
        </p>
      </section>
      <section className="howItWorks">
        <h3>How it Works</h3>
        <section className="list">
          <h4>Create a Profile</h4>
          <p>
            Answer the lifestyle questions to be accurately matched with
            available rescues
          </p>
        </section>
        <section className="list">
          <h4>Match</h4>
          <p>
            Match with rescue animals, read their descriptions, and favorite if
            it's a good fit or "x" if not
          </p>
        </section>
        <section className="list">
          <h4>Rescue</h4>
          <p>
            Choose the animal you love and send in an application right to the
            rescue center
          </p>
        </section>
      </section>
      <footer>
        <section className="footerName">Name</section>
        <section className="socialMedia">Twitter Logo, FB logo</section>
      </footer>
    </>
  )
}

export default HomePage
