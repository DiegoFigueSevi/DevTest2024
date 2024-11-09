import React, { useState } from 'react'
import { Route, Routes } from 'react-router-dom'
import Home from './pages/Home'
import Header from './components/Header'
import CreateForm from './pages/CreateForm'

const App = () => {

  const [headerTitle, setheaderTitle] = useState('Online Poll')

  return (
    <>
      <Header pageTitle={headerTitle} />
      <Routes>
          <Route path='/' element={<Home />} />
          <Route path='/create' element={<CreateForm />} />
      </Routes>
    </>
  )
}

export default App
