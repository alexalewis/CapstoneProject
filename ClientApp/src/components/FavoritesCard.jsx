import React from 'react'
import axios from 'axios'
import '../styles/PetCard.scss'
import { faHeart } from '@fortawesome/free-solid-svg-icons'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'

const FavoritesCard = props => {
  const deleteAFavorite = async animal => {
    console.log(localStorage.getItem('token'))
    const resp = await axios({
      method: 'DELETE',
      url: `/api/profile/favorites/${animal.id}`,
      data: {
        animalId: animal.id,
      },
      headers: {
        Authorization: 'Bearer ' + localStorage.getItem('token'),
      },
    })
    console.log(resp.data)
  }

  return (
    <>
      <section className="card">
        <img className="petImage" src={props.animal.imageUrl} alt="" />
        <section className="animalHeader">
          <p className="animalName">{props.animal.name}</p>
          <button
            className="favoriteAnimal"
            onClick={() => deleteAFavorite(props.animal)}
          >
            <a className="reload" href="javascript:location.reload(true)">
              <FontAwesomeIcon icon={faHeart} />
            </a>
          </button>
        </section>
        <p>{props.animal.description}</p>
        <p>{props.animal.age}</p>
        <p>{props.animal.gender}</p>
        <p>
          <a className="bold">Breed</a> : {props.animal.breed}
        </p>
        <p>
          <a className="bold">Rescue Center</a> : {props.animal.rescueCenter}
        </p>
        <p>
          <a className="bold">Up to date on vaccines?</a> :{' '}
          {props.animal.isVaccinated ? 'Yes' : 'No'}
        </p>
        <p>
          <a className="bold">Are they neutered?</a> :{' '}
          {props.animal.isNeutered ? 'Yes' : 'No'}
        </p>
      </section>
    </>
  )
}

export default FavoritesCard
