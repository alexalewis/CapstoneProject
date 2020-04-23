import React from 'react'
import '../styles/PetCard.scss'

const PetCard = props => {
  return (
    <>
      <section className="card">
        <img className="petImage" src={props.animal.imageUrl} alt="sophie" />
        <p>{props.animal.name}</p>
        <p>{props.animal.description}</p>
        <p>{props.animal.age}</p>
        <p>{props.animal.gender}</p>
        <p>Breed : {props.animal.breed}</p>
        <p>Rescue Center : {props.animal.rescueCenter}</p>
        <p>
          Up to date on vaccines? : {props.animal.IsVaccinated ? 'No' : 'Yes'}
        </p>
        <p>Are they neutered? : {props.animal.IsNeutered ? 'No' : 'Yes'}</p>
      </section>
    </>
  )
}

export default PetCard
