import React, { useState } from 'react'
import axios from 'axios'
import { Link } from 'react-router-dom'

const Questions = () => {
  const [age, setAge] = useState('')
  const [zipcode, setZipcode] = useState('')
  const [housingType, setHousingType] = useState('')
  const [haveYard, setHaveYard] = useState(false)
  const [lookingFor, setLookingFor] = useState('')
  const [isActive, setIsActive] = useState(false)
  const [typeOfOtherAnimal, setTypeOfOtherAnimal] = useState('')
  const [smallChildren, setSmallChildren] = useState(false)

  const changeHousingType = value => {
    if (value === 'apartment') {
      setHousingType(value)
    } else if (value === 'house') {
      setHousingType(value)
    }
  }

  const changeToHaveYard = value => {
    if (value === 'yes') {
      setHaveYard(true)
    } else {
      setHaveYard(false)
    }
  }

  const changeToLookingFor = value => {
    if (value === 'cat') {
      setLookingFor(value)
    } else {
      setLookingFor(value)
    }
  }

  const changeToIsActive = value => {
    if (value === 'yes') {
      setIsActive(true)
    } else {
      setIsActive(false)
    }
  }

  const changeTypeOfOtherAnimal = value => {
    if (value === 'cat') {
      setTypeOfOtherAnimal(value)
    } else if (value === 'dog') {
      setTypeOfOtherAnimal(value)
    } else {
      setTypeOfOtherAnimal(value)
    }
  }

  const changeSmallChildren = value => {
    if (value === 'yes') {
      setSmallChildren(true)
    } else {
      setSmallChildren(false)
    }
  }

  const sendAnswersToApi = async () => {
    const resp = await axios.post(
      '/api/questionnaire',
      {
        Age: age,
        Zipcode: zipcode,
        HousingType: housingType,
        HaveYard: haveYard,
        LookingFor: lookingFor,
        IsActive: isActive,
        TypeOfOtherAnimal: typeOfOtherAnimal,
        SmallChildren: smallChildren,
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
      <p className="directions">
        Just fill out these questions to get started finding a match!
      </p>
      <form className="questionForm">
        <p className="question" id="topOfPage">
          How old are you?
        </p>
        <section className="inputText">
          <input
            type="text"
            placeholder="Ex: 19"
            id="age"
            name="Age"
            value={age}
            onChange={e => setAge(e.target.value)}
          ></input>
        </section>
        <p className="question">What is your zip code?</p>
        <section className="inputText">
          <input
            type="text"
            placeholder="Ex: 33713"
            id="zipcode"
            name="Zipcode"
            value={zipcode}
            onChange={e => setZipcode(e.target.value)}
          ></input>
        </section>
        <p className="question">What type of housing do you have?</p>
        <section className="inputRadio">
          <input
            type="radio"
            id="apartment"
            name="HousingType"
            value="apartment"
            onChange={e => changeHousingType(e.target.value)}
          ></input>
          <label htmlFor="apartment">Apartment</label>
        </section>
        <section className="inputRadio">
          <input
            className="longerStringOne"
            type="radio"
            id="house"
            name="HousingType"
            value="house"
            onChange={e => changeHousingType(e.target.value)}
          ></input>
          <label htmlFor="house">Single Family Home</label>
        </section>
        <p className="question">Do you have a yard?</p>
        <section className="inputRadio">
          <input
            type="radio"
            id="yesYard"
            name="HaveYard"
            value="yes"
            onChange={e => changeToHaveYard(e.target.value)}
          ></input>
          <label htmlFor="yesYard">Yes</label>
        </section>
        <section className="inputRadio">
          <input
            type="radio"
            id="noYard"
            name="HaveYard"
            value="no"
            onChange={e => changeToHaveYard(e.target.value)}
          ></input>
          <label htmlFor="noYard">No</label>
        </section>
        <p className="question">Are you searching for a cat or dog?</p>
        <section className="inputRadio">
          <input
            type="radio"
            id="yesCat"
            name="LookingFor"
            value="cat"
            onChange={e => changeToLookingFor(e.target.value)}
          ></input>
          <label htmlFor="yesCat">Cat</label>
        </section>
        <section className="inputRadio">
          <input
            type="radio"
            id="yesDog"
            name="LookingFor"
            value="dog"
            onChange={e => changeToLookingFor(e.target.value)}
          ></input>
          <label htmlFor="yesDog">Dog</label>
        </section>
        <p className="question">Do you consider yourself to be active?</p>
        <section className="inputRadio">
          <input
            type="radio"
            id="yesActive"
            name="IsActive"
            value="yes"
            onChange={e => changeToIsActive(e.target.value)}
          ></input>
          <label htmlFor="yesActive">Yes</label>
        </section>
        <section className="inputRadio">
          <input
            type="radio"
            id="noActive"
            name="IsActive"
            value="no"
            onChange={e => changeToIsActive(e.target.value)}
          ></input>
          <label htmlFor="noActive">No</label>
        </section>
        <p className="question">What type of other animal do you have?</p>
        <section className="inputRadio">
          <input
            type="radio"
            id="cat"
            name="TypeOfOtherAnimal"
            value="cat"
            onChange={e => changeTypeOfOtherAnimal(e.target.value)}
          ></input>
          <label htmlFor="cat">Cat</label>
        </section>
        <section className="inputRadio">
          <input
            type="radio"
            id="dog"
            name="TypeOfOtherAnimal"
            value="dog"
            onChange={e => changeTypeOfOtherAnimal(e.target.value)}
          ></input>
          <label htmlFor="dog">Dog</label>
        </section>
        <section className="inputRadio">
          <input
            className="longerStringTwo"
            type="radio"
            id="both"
            name="TypeOfOtherAnimal"
            value="cat and dog"
            onChange={e => changeTypeOfOtherAnimal(e.target.value)}
          ></input>
          <label htmlFor="both">Cat and Dog</label>
        </section>
        <section className="inputRadio">
          <input
            type="radio"
            id="none"
            name="TypeOfOtherAnimal"
            value="none"
            onChange={e => changeTypeOfOtherAnimal(e.target.value)}
          ></input>
          <label htmlFor="none">None</label>
        </section>
        <p className="question">
          Do you have small children that are > 7 years old?
        </p>
        <section className="inputRadio">
          <input
            type="radio"
            id="yesChildren"
            name="SmallChildren"
            value="yes"
            onChange={e => changeSmallChildren(e.target.value)}
          ></input>
          <label htmlFor="yesChildren">Yes</label>
        </section>
        <section className="inputRadio">
          <input
            type="radio"
            id="noChildren"
            name="SmallChildren"
            value="no"
            onChange={e => changeSmallChildren(e.target.value)}
          ></input>
          <label htmlFor="noChildren">No</label>
        </section>
      </form>
      <section className="submitQuestionButton">
        <Link to="/profile">
          <button onClick={sendAnswersToApi}>Submit</button>
        </Link>
      </section>
    </>
  )
}

export default Questions
