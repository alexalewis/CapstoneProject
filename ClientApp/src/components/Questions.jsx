import React from 'react'

const Questions = () => {
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
          <input type="radio" id="true" name="HaveYard" value="true"></input>
          <label htmlFor="true">Yes</label>
        </section>
        <section className="inputRadio">
          <input type="radio" id="false" name="HaveYard" value="false"></input>
          <label htmlFor="false">No</label>
        </section>
        <p className="question">
          Is your yard fenced? Select "No" if you do not have a yard.
        </p>
        <section className="inputRadio">
          <input type="radio" id="true" name="IsFenced" value="true"></input>
          <label htmlFor="true">Yes</label>
        </section>
        <section className="inputRadio">
          <input type="radio" id="false" name="IsFenced" value="false"></input>
          <label htmlFor="false">No</label>
        </section>
        <p className="question">Do you consider yourself to be active?</p>
        <section className="inputRadio">
          <input type="radio" id="true" name="IsActive" value="true"></input>
          <label htmlFor="true">Yes</label>
        </section>
        <section className="inputRadio">
          <input type="radio" id="false" name="IsActive" value="false"></input>
          <label htmlFor="false">No</label>
        </section>
        <p className="question">Do you have other animals?</p>
        <section className="inputRadio">
          <input
            type="radio"
            id="true"
            name="OtherAnimals"
            value="true"
          ></input>
          <label htmlFor="true">Yes</label>
        </section>
        <section className="inputRadio">
          <input
            type="radio"
            id="false"
            name="OtherAnimals"
            value="false"
          ></input>
          <label htmlFor="false">No</label>
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
            id="true"
            name="SmallChildren"
            value="true"
          ></input>
          <label htmlFor="true">Yes</label>
        </section>
        <section className="inputRadio">
          <input
            type="radio"
            id="false"
            name="SmallChildren"
            value="false"
          ></input>
          <label htmlFor="false">No</label>
        </section>
      </form>
      <section className="submitQuestionButton">
        <button>Submit</button>
      </section>
    </>
  )
}

export default Questions
