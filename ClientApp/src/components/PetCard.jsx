import React from 'react'
import axios from 'axios'
import '../styles/PetCard.scss'
import { faHeart } from '@fortawesome/free-solid-svg-icons'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'

const PetCard = props => {
  const saveFavorites = async animal => {
    const resp = await axios.post(
      `api/profile/favorites/${animal.id}`,
      {
        animalId: animal.id,
      },
      {
        headers: {
          Authorization: 'Bearer ' + localStorage.getItem('token'),
        },
      }
    )
    console.log(resp.data)
  }

  return (
    <>
      <section className="eachCard">
        <section className="card">
          <img className="petImage" src={props.animal.imageUrl} alt="" />
          <section className="animalHeader">
            <p className="animalName">{props.animal.name}</p>
            <button
              className="favoriteAnimal"
              onClick={() => saveFavorites(props.animal)}
            >
              <FontAwesomeIcon icon={faHeart} />
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
      </section>
    </>
  )
}

export default PetCard
