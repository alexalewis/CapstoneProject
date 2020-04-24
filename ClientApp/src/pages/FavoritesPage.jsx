import React, { useState, useEffect } from 'react'
import axios from 'axios'
import FavoritesCard from '../components/FavoritesCard'

const FavoritesPage = props => {
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
      <section className="petCard">
        {favorites.map(favorite => {
          return <FavoritesCard key={favorite.id} animal={favorite} />
        })}
      </section>
    </>
  )
}

export default FavoritesPage
