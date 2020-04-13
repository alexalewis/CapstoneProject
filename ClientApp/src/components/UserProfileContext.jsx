import { createContext, useContext } from 'react'

export const UserProfileContext = createContext()

export const useUserProfile = () => useContext(UserProfileContext)
