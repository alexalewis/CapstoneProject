import React, { useState, useCallback, useEffect } from 'react'
import { Route, Switch } from 'react-router'
import { Redirect } from 'react-router-dom'
import HomePage from './pages/HomePage'
import SignInPage from './pages/SignInPage'
import ProfilePage from './pages/ProfilePage'
import SignUpPage from './pages/SignUpPage'
import QuestionnairePage from './pages/QuestionnairePage'
import MatchesPage from './pages/MatchesPage'
import FavoritesPage from './pages/FavoritesPage'
import NotFound from './pages/NotFound'
import './custom.scss'
import axios from 'axios'
import { UserProfileContext } from './components/UserProfileContext'

const App = () => {
  const [user, setUser] = useState()
  const token = localStorage.getItem('token')

  const reloadUser = useCallback(() => {
    axios
      .get('/api/profile', {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      })
      .then(response => {
        console.log('loaded the user', response.data)
        setUser(response.data)
      })
  }, [token])

  useEffect(() => {
    reloadUser()
  }, [token])

  return (
    <UserProfileContext.Provider value={{ user: user, reloadUser: reloadUser }}>
      <Switch>
        <Route exact path="/" component={HomePage} />
        <Route exact path="/sign-in" component={SignInPage}></Route>
        <Route exact path="/profile" component={ProfilePage}></Route>
        <Route exact path="/sign-up" component={SignUpPage}></Route>
        <Route exact path="/matches" component={MatchesPage}></Route>
        <Route exact path="/favorites" component={FavoritesPage}></Route>
        <Route
          exact
          path="/questionnaire"
          render={() => {
            if (localStorage.getItem('token')) {
              return <QuestionnairePage />
            } else {
              return <Redirect to="/sign-up" />
            }
          }}
        ></Route>
        <Route exact path="*" component={NotFound} />
      </Switch>
    </UserProfileContext.Provider>
  )
}

export default App
