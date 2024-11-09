import React, { useState } from 'react'
import { Route, Routes } from 'react-router-dom'
import Home from './pages/Home'
import Header from './components/Header'

const App = () => {

  const [headerTitle, setheaderTitle] = useState('Online Poll')

  return (
    <>
      <Header pageTitle={headerTitle} />
      <Routes>
          <Route path='/' element={<Home />} />
      </Routes>
    </>
  )
}

export default App
