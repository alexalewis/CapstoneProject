import React, { useState, useEffect } from 'react'
import axios from 'axios'
import { Link } from 'react-router-dom'

const Matches = () => {
  const getMatches = async () => {
    const resp = await axios.get('/api/profile/matches', {
      headers: {
        Authorization: 'Bearer ' + localStorage.getItem('token'),
      },
    })
    console.log(resp.data)
  }

  useEffect(() => {
    getMatches()
  }, [])

  return (
    <>
      <section>
        <Link to="/profile">
          <button>Back to my profile</button>
        </Link>
      </section>
      <section className="matchCard">
        <p>this is where animal match will go</p>
      </section>
    </>
  )
}

export default Matches
