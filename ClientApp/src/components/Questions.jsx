import React, { useState } from 'react'

const Questions = () => {
  const [bool, setBool] = useState([])

  return (
    <>
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
            value=""
          ></input>
        </section>
        <p className="question">What is your zip code?</p>
        <section className="inputText">
          <input
            type="text"
            placeholder="Ex: 33713"
            id="zipcode"
            name="Zipcode"
            value=""
          ></input>
        </section>
        <p className="question">What type of housing do you have?</p>
        <section className="inputRadio">
          <input
            type="radio"
            id="apartment"
            name="HousingType"
            value="apartment"
          ></input>
          <label htmlFor="apartment">Apartment</label>
        </section>
        <section className="inputRadio">
          <input
            type="radio"
            id="house"
            name="HousingType"
            value="house"
          ></input>
          <label htmlFor="house">Single Family Home</label>
        </section>
        <p className="question">Do you have a yard?</p>
        <section className="inputRadio">
          <input type="radio" id="yesYard" name="HaveYard" value="yes"></input>
          <label htmlFor="yesYard">Yes</label>
        </section>
        <section className="inputRadio">
          <input type="radio" id="noYard" name="HaveYard" value="no"></input>
          <label htmlFor="noYard">No</label>
        </section>
        <p className="question">
          Is your yard fenced? Select "No" if you do not have a yard.
        </p>
        <section className="inputRadio">
          <input type="radio" id="yesFence" name="IsFenced" value="yes"></input>
          <label htmlFor="yesFence">Yes</label>
        </section>
        <section className="inputRadio">
          <input type="radio" id="noFence" name="IsFenced" value="no"></input>
          <label htmlFor="noFence">No</label>
        </section>
        <p className="question">Do you consider yourself to be active?</p>
        <section className="inputRadio">
          <input
            type="radio"
            id="yesActive"
            name="IsActive"
            value="yes"
          ></input>
          <label htmlFor="yesActive">Yes</label>
        </section>
        <section className="inputRadio">
          <input type="radio" id="noActive" name="IsActive" value="no"></input>
          <label htmlFor="noActive">No</label>
        </section>
        <p className="question">Do you have other animals?</p>
        <section className="inputRadio">
          <input
            type="radio"
            id="yesAnimals"
            name="OtherAnimals"
            value="yes"
          ></input>
          <label htmlFor="yesAnimals">Yes</label>
        </section>
        <section className="inputRadio">
          <input
            type="radio"
            id="noAnimals"
            name="OtherAnimals"
            value="no"
          ></input>
          <label htmlFor="noAnimals">No</label>
        </section>
        <p className="question">What type of other animal do you have?</p>
        <section className="inputRadio">
          <input
            type="radio"
            id="cat"
            name="TypeOfOtherAnimal"
            value="cat"
          ></input>
          <label htmlFor="cat">Cat</label>
        </section>
        <section className="inputRadio">
          <input
            type="radio"
            id="dog"
            name="TypeOfOtherAnimal"
            value="dog"
          ></input>
          <label htmlFor="dog">Dog</label>
        </section>
        <section className="inputRadio">
          <input
            type="radio"
            id="none"
            name="TypeOfOtherAnimal"
            value="none"
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
          ></input>
          <label htmlFor="yesChildren">Yes</label>
        </section>
        <section className="inputRadio">
          <input
            type="radio"
            id="noChildren"
            name="SmallChildren"
            value="no"
          ></input>
          <label htmlFor="noChildren">No</label>
        </section>
      </form>
      <section className="submitQuestionButton">
        <button>Submit</button>
      </section>
    </>
  )
}

export default Questions
