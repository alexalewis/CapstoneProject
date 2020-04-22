import React from 'react'

const PetCard = props => {
  return (
    <>
      <img src={props.animal.imageUrl} alt="" />
      <p>{props.animal.name}</p>
    </>
  )
}

export default PetCard
