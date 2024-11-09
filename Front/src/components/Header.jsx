import React from 'react'

const Header = ({pageTitle}) => {
  return (
    <div className='px-6 py-4 md:px-[300px] bg-white shadow-md  shadow-gray-500 relative -z-1'>
      <h1 className='font-bold text-2xl'>{pageTitle}</h1>
    </div>
  )
}

export default Header
