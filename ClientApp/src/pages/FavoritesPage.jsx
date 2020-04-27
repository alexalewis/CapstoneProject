import React, { useState, useEffect } from 'react'
import axios from 'axios'
import NavBar from '../components/NavBar'
import Footer from '../components/Footer'
import { Link } from 'react-router-dom'
import FavoritesCard from '../components/FavoritesCard'

const FavoritesPage = () => {
  const [favorites, setFavorites] = useState([])

  console.log(favorites)

  const getFavorites = async () => {
    const resp = await axios.get('/api/profile/favorites', {
      headers: {
        Authorization: 'Bearer ' + localStorage.getItem('token'),
      },
    })
    console.log(resp.data)
    setFavorites(resp.data)
  }

  useEffect(() => {
    getFavorites()
  }, [])

  return (
    <>
      <NavBar />
      <section className="profileButton">
        <Link to="/profile">
          <button className="backToProfile">Back to my profile</button>
        </Link>
      </section>
      <section className="petCard">
        {favorites.map(favorite => {
          return <FavoritesCard key={favorite.id} animal={favorite} />
        })}
      </section>
      <Footer />
    </>
  )
}

export default FavoritesPage
