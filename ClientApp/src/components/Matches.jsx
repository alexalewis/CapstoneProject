import React, { useState, useEffect } from 'react'
import axios from 'axios'
import { Link } from 'react-router-dom'
import PetCard from '../components/PetCard'

const Matches = () => {
  const [pets, setPets] = useState([])

  const getMatches = async () => {
    const resp = await axios.get('/api/profile/matches', {
      headers: {
        Authorization: 'Bearer ' + localStorage.getItem('token'),
      },
    })
    console.log(resp.data)
    setPets(resp.data)
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
      <section className="petCard">
        {pets.map(pet => {
          return <PetCard key={pet.id} animal={pet} />
        })}
      </section>
    </>
  )
}

export default Matches
