import React, { useEffect } from 'react'
import axios from 'axios'
import Questions from '../components/Questions'
import NavBar from '../components/NavBar'
import Footer from '../components/Footer'
import '../styles/QuestionnairePage.scss'

const QuestionnairePage = () => {
  return (
    <>
      <NavBar />
      <Questions />
      <Footer />
    </>
  )
}

export default QuestionnairePage
