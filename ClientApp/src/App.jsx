import React, { Component } from 'react'
import { Route, Switch } from 'react-router'
import { Redirect } from 'react-router-dom'
import HomePage from './pages/HomePage'
import SignInPage from './pages/SignInPage'
import ProfilePage from './pages/ProfilePage'
import SignUpPage from './pages/SignUpPage'
import QuestionnairePage from './pages/QuestionnairePage'
import NotFound from './pages/NotFound'
import './custom.scss'

export default class App extends Component {
  static displayName = App.name

  render() {
    return (
      <Switch>
        <Route exact path="/" component={HomePage} />
        <Route exact path="/sign-in" component={SignInPage}></Route>
        <Route exact path="/profile" component={ProfilePage}></Route>
        <Route exact path="/sign-up" component={SignUpPage}></Route>
        <Route
          exact
          path="/questionnaire"
          render={() => {
            if (localStorage.getItem('token')) {
              return <QuestionnairePage />
            } else {
              return <Redirect to="/sign-in" />
            }
          }}
        ></Route>
        <Route exact path="*" component={NotFound} />
      </Switch>
    )
  }
}
