import React from 'react'
import { Link } from 'react-router-dom'

const NavBar = () => {
  return (
    <>
      {/* <img logo></img> */}
      <nav>
        <ul className="menu">
          <li>
            <Link className="link" to="/">
              Home
            </Link>
          </li>
          <li>
            <Link className="link" to="/sign-up">
              Find a Match
            </Link>
          </li>
          <li>
            <Link className="link" to="/sign-in">
              Sign In
            </Link>
          </li>
        </ul>
      </nav>
    </>
  )
}

export default NavBar
